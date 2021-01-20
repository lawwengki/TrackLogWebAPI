using CoreBaseLib.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Npgsql;

namespace SqlLib2
{
    public class NpgSqlNonQuery : NpgSqlBase, INpgDbNonQuery
    {
        private readonly IConfiguration _configuration;
        public NpgSqlNonQuery(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public NpgSqlNonQuery(string connStr, IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
            ConnStr = connStr;
        }
        public RVal ExecuteNpgNonQuery(string sqlTxt)
        {
            var cmd = new NpgsqlCommand();
            cmd.CommandText = sqlTxt;
            return ExecuteNpgNonQuery(cmd);
        }

        public RVal ExecuteNpgNonQuery(List<string> sqlTxtList)
        {
            List<IDbCommand> cmdList = new List<IDbCommand>();
            foreach (string sqlTxt in sqlTxtList)
            {
                var cmd = new NpgsqlCommand();
                cmd.CommandText = sqlTxt;
                cmdList.Add(cmd);
            }

            return ExecuteNpgNonQuery(cmdList);
        }

        public RVal ExecuteNpgNonQuery(IDbCommand cmd)
        {
            using (NpgsqlConnection conn = this.GetConnection())
            {
                RVal rval = new RVal();
                CommittableTransaction ct = new CommittableTransaction();
                conn.Open();
                conn.EnlistTransaction(ct);
                cmd.Connection = conn;
                try
                {
                    rval.RStatus = true;
                    cmd.ExecuteNonQuery();
                    ct.Commit();
                }
                catch (Exception ex)
                {
                    rval.RStatus = false;
                    ErrorNLog(cmd, ex);
                    ct.Rollback();
                }
                finally
                {
                    conn.Close();
                }

                return rval;
            }
        }
      
        public RVal ExecuteNpgNonQuery(List<IDbCommand> cmdList)
        {
            using (NpgsqlConnection conn = this.GetConnection())
            {
                RVal rval = new RVal();
                CommittableTransaction ct = new CommittableTransaction();
                conn.Open();
                conn.EnlistTransaction(ct);
                try
                {
                    foreach (var cmd in cmdList)
                    {
                        try
                        {
                            rval.RStatus = true;
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        catch (Exception ex)
                        {
                            rval.RStatus = false;
                            ErrorNLog(cmd, ex);
                            ct.Rollback();
                            return rval;
                        }
                    }
                    ct.Commit();
                }
                finally
                {
                    conn.Close();
                }
                return rval;
            }
        }

        public RVal ExecuteNpgScalar(IDbCommand cmd)
        {
            using (NpgsqlConnection conn = this.GetConnection())
            {
                RVal rval = new RVal();
                CommittableTransaction ct = new CommittableTransaction();
                conn.Open();
                conn.EnlistTransaction(ct);
                cmd.Connection = conn;
                try
                {
                    var srObj = cmd.ExecuteScalar();
                    rval.RStatus = true;
                    rval.DVal = srObj;
                    ct.Commit();
                }
                catch (Exception ex)
                {
                    rval.RStatus = false;
                    ErrorNLog(cmd, ex);
                    ct.Rollback();
                }
                finally
                {
                    conn.Close();
                }

                return rval;
            }
        }

        private void ErrorNLog(IDbCommand cmd, Exception ex)
        {
            var logger = Logger();
            logger.Trace(cmd.CommandText);
            logger.Trace(ex.ToString);
        }
    }
}
