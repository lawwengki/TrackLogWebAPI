using CoreBaseLib.Models;
using CoreBaseLib.Sample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreBase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;
        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        [HttpGet]
        public ActionResult<SampleModel> GetData(Guid guid)
        {
            var result = _sampleService.GetData(guid);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> AddData([FromBody]SampleModel data)
        {
            var result = _sampleService.AddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<RVal> EditData(SampleModel data)
        {
            var result = _sampleService.EditData(data);
            return new JsonResult(result);
        }

    }
}
