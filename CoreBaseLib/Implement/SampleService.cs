using CoreBaseLib.Models;
using Microsoft.Extensions.Configuration;
using SqlLib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBaseLib.Sample
{
    public class SampleService : ISampleService
    {
        private readonly IConfiguration _configuration;
        private readonly DbHelper _dbHelper;
        private readonly DapperHelper _dapperHelper;
        public SampleService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dapperHelper = new DapperHelper(_configuration);
            _dbHelper = new DbHelper(_configuration);
        }
        public RVal AddData(SampleModel data)
        {
            var cmdHelper = _dbHelper.GetCmdHelper();
            cmdHelper.TableName = "Test";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNonQuery(cmd);
            return rval;
        }

        public RVal EditData(SampleModel data)
        {
            var cmdHelper = _dbHelper.GetCmdHelper();
            cmdHelper.TableName = "Test";
            var cmd = cmdHelper.GetUpdateCmd(data, "SampleId=@SampleId");
            var rval = _dbHelper.ExecuteNonQuery(cmd);
            return rval;
        }

        public SampleModel GetData(Guid sampleId)
        {
            var sqlTxt = @"SELECT * FROM Test WHERE SampleId=@sampleId ";
            var result = _dapperHelper.Query<SampleModel>(sqlTxt, new { sampleId }).FirstOrDefault();
            return result;
        }
    }
}
