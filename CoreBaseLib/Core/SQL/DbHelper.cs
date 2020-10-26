using CoreBaseLib.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace SqlLib2
{
    /// <summary>
    /// IDbManager 的摘要描述
    /// </summary>
    public class DbHelper : IDbNonQuery, IDbQuery, INpgDbNonQuery, INpgDbQuery
    {
        private string _connStr = "";
        private IConfiguration _configuration;
        private IDbQuery _dbQuery;
        private IDbNonQuery _dbNonQuery;
        private INpgDbQuery _NpgDbQuery;
        private INpgDbNonQuery _NpgDbNonQuery;
        private DapperHelper _dapperHelper;
        private ISqlCmdHelper _cmdHelper;
        private IDbCommand _dbCmd;
        public DbHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DapperHelper DapperHelper
        {
            get
            {
                if (_dapperHelper == null)
                    _dapperHelper = new DapperHelper();
                return _dapperHelper;
            }
        }
        public DbHelper(string connStr)
        {
            _connStr = connStr;
        }

        public IDbCommand GetDbCmd()
        {
            if (_dbCmd == null)
                _dbCmd = new SqlCommand();
            return _dbCmd;
        }
        public IDbCommand GetNpgCommand()
        {
            if (_dbCmd == null)
                _dbCmd = new NpgsqlCommand();
            return _dbCmd;
        }

        public IDbQuery GetDbQuery()
        {
            if (_dbQuery == null)
            {
                if (_connStr == "")
                    _dbQuery = new MsSqlQuery(_configuration);
                else
                    _dbQuery = new MsSqlQuery(_connStr, _configuration);
            }
            return _dbQuery;
        }

        public IDbQuery GetNpgDbQuery()
        {
            if (_dbQuery == null)
            {
                if (_connStr == "")
                    _dbQuery = new NpgSqlQuery(_configuration);
                else
                    _dbQuery = new NpgSqlQuery(_connStr, _configuration);
            }
            return _dbQuery;
        }

        public IDbNonQuery GetNonQuery()
        {
            if (_dbNonQuery == null)
            {
                if (_connStr == "")
                    _dbNonQuery = new MsSqlNonQuery(_configuration);
                else
                    _dbNonQuery = new MsSqlNonQuery(_connStr, _configuration);
            }
            return _dbNonQuery;
        }

        public INpgDbNonQuery GetNpgNonQuery()
        {
            if (_NpgDbNonQuery == null)
            {
                if (_connStr == "")
                    _NpgDbNonQuery = new NpgSqlNonQuery(_configuration);
                else
                    _NpgDbNonQuery = new NpgSqlNonQuery(_connStr, _configuration);
            }
            return _NpgDbNonQuery;
        }

        public ISqlCmdHelper GetCmdHelper()
        {
            if (_cmdHelper == null)
                _cmdHelper = new MsSqlCmdHelper();
            return _cmdHelper;
        }

        public ISqlCmdHelper GetNpgCmdHelper()
        {
            if (_cmdHelper == null)
                _cmdHelper = new NpgSqlCmdHelper();
            return _cmdHelper;
        }

        public DataTable ExecuteQuery(IDbCommand cmd)
        {
            GetDbQuery();
            return _dbQuery.ExecuteQuery(cmd);
        }

        public DataTable ExecuteNpgQuery(IDbCommand cmd)
        {
            GetNpgDbQuery();
            return _NpgDbQuery.ExecuteNpgQuery(cmd);
        }

        public DataTable ExecuteQuery(string sqlTxt)
        {
            GetDbQuery();
            return _dbQuery.ExecuteQuery(sqlTxt);
        }

        public DataTable ExecuteNpgQuery(string sqlTxt)
        {
            GetNpgDbQuery();
            return _NpgDbQuery.ExecuteNpgQuery(sqlTxt);
        }

        public DataSet ExecuteQuery(List<IDbCommand> cmdList)
        {
            GetDbQuery();
            return _dbQuery.ExecuteQuery(cmdList);
        }

        public DataSet ExecuteNpgQuery(List<IDbCommand> cmdList)
        {
            GetNpgDbQuery();
            return _NpgDbQuery.ExecuteNpgQuery(cmdList);
        }

        public DataSet ExecuteQuery(List<string> sqlTxtList)
        {
            GetDbQuery();
            return _dbQuery.ExecuteQuery(sqlTxtList);
        }

        public DataSet ExecuteNpgQuery(List<string> sqlTxtList)
        {
            GetNpgDbQuery();
            return _NpgDbQuery.ExecuteNpgQuery(sqlTxtList);
        }

        public RVal ExecuteNonQuery(string sqlTxt)
        {
            GetNonQuery();
            return _dbNonQuery.ExecuteNonQuery(sqlTxt);
        }

        public RVal ExecuteNpgNonQuery(string sqlTxt)
        {
            GetNpgNonQuery();
            return _NpgDbNonQuery.ExecuteNpgNonQuery(sqlTxt);
        }

        public RVal ExecuteNonQuery(List<string> sqlTxtList)
        {
            GetNonQuery();
            return _dbNonQuery.ExecuteNonQuery(sqlTxtList);
        }

        public RVal ExecuteNpgNonQuery(List<string> sqlTxtList)
        {
            GetNpgNonQuery();
            return _NpgDbNonQuery.ExecuteNpgNonQuery(sqlTxtList);
        }
        public RVal ExecuteNonQuery(IDbCommand cmd)
        {
            GetNonQuery();
            return _dbNonQuery.ExecuteNonQuery(cmd);
        }

        public RVal ExecuteNpgNonQuery(IDbCommand cmd)
        {
            GetNpgNonQuery();
            return _NpgDbNonQuery.ExecuteNpgNonQuery(cmd);
        }

        public RVal ExecuteNonQuery(List<IDbCommand> cmdList)
        {
            GetNonQuery();
            return _dbNonQuery.ExecuteNonQuery(cmdList);
        }

        public RVal ExecuteNpgNonQuery(List<IDbCommand> cmdList)
        {
            GetNpgNonQuery();
            return _NpgDbNonQuery.ExecuteNpgNonQuery(cmdList);
        }

        public RVal ExecuteScalar(IDbCommand cmd)
        {
            GetNonQuery();
            return _dbNonQuery.ExecuteScalar(cmd);
        }

        public RVal ExecuteNpgScalar(IDbCommand cmd)
        {
            GetNpgNonQuery();
            return _NpgDbNonQuery.ExecuteNpgScalar(cmd);
        }
    }

}