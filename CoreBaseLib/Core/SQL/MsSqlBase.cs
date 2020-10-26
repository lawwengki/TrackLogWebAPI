using Microsoft.Extensions.Configuration;
using NLog;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlLib2
{
    public class MsSqlBase
    {
      
        private string _connStr;
        public string ConnStr { get; set; }
        private readonly IConfiguration _configuration;
        public MsSqlBase(IConfiguration configuration)
        {
            _configuration = configuration;
            _connStr = _configuration.GetSection("ConnectionStrings:DefaultConnection").GetSection("ConnectionString").Value;
        }
        public SqlConnection GetConnection()
        {
            if (!string.IsNullOrEmpty(ConnStr))
                _connStr = ConnStr;
            SqlConnection conn = new SqlConnection();
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
