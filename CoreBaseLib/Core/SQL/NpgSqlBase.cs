using Microsoft.Extensions.Configuration;
using NLog;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;

namespace SqlLib2
{
    public class NpgSqlBase
    {
      
        private string _connStr;
        public string ConnStr { get; set; }
        private readonly IConfiguration _configuration;
        public NpgSqlBase(IConfiguration configuration)
        {
            _configuration = configuration;
            _connStr = _configuration.GetSection("ConnectionStrings:DefaultConnection").GetSection("ConnectionString").Value;
        }
        public NpgsqlConnection GetConnection()
        {
            if (!string.IsNullOrEmpty(ConnStr))
                _connStr = ConnStr;
            NpgsqlConnection conn = new NpgsqlConnection();
            conn.ConnectionString = _connStr;
            return conn;
        }

        public Logger Logger()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            return logger;
        }
    }
}
