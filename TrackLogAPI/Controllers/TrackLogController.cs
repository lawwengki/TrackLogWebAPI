using CoreBaseLib.Models;
using CoreBaseLib.Sample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreBase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrackLogController : ControllerBase
    {
        public static string tokenPwd = "HAWOOO";
        private readonly ITrackLog _TrackLog;
        public TrackLogController(ITrackLog TrackLog)
        {
            _TrackLog = TrackLog;
        }

        [HttpPost]
        public ActionResult<string> AddtoCart([FromBody] AddtoCartlgModel data)
        {
            var result = _TrackLog.AddtoCartlgAddData(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> AddPaymentInfo([FromBody] AddPaymentInfolgModel data)
        {
            var result = _TrackLog.AddPaymentInfolgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> AddToWishlist([FromBody] AddToWishlistlgModel data)
        {
            var result = _TrackLog.AddToWishlistlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> CompleteRegistration([FromBody] CompleteRegistrationlgModel data)
        {
            var result = _TrackLog.CompleteRegistrationlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> InitiateCheckout([FromBody] InitiateCheckoutlgModel data)
        {
            var result = _TrackLog.InitiateCheckoutlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> PageView([FromBody] PageViewlgModel data)
        {
            var result = _TrackLog.PageViewlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Purchase([FromBody] PurchaselgModel data)
        {
            var result = _TrackLog.PurchaselgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Search([FromBody] SearchlgModel data)
        {
            var result = _TrackLog.SearchlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Subscribe([FromBody] SubscribelgModel data)
        {
            var result = _TrackLog.SubscribelgAddData(data);
            return new JsonResult(result);
        }
        [HttpGet]
        public ActionResult ResetAllEventsData()
        {
            var result = _TrackLog.ResetEvents();
            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult GetAddtoCart()
        {
            var result = new List<AddtoCartRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                        {
                    result = _TrackLog.GetAddToCartData();
                }
                else {  
                }
            }
            else {
            }

            return new JsonResult(result);
        }



        [HttpGet]
        public ActionResult GetPaymentInfo()
        {
            var result = new List<AddPaymentInfoRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetPaymentInfoData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult GetAddToWishList()
        {
            var result = new List<AddToWishlistRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetAddToWishListData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult GetCompleteRegistration()
        {
            var result = new List<CompleteRegistrationRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetCompleteRegistrationData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);

        }
        [HttpGet]
        public ActionResult GetInitiateCheckOut()
        {
            var result = new List<InitiateCheckoutRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetInitiateCheckOutData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult<PageViewRModel> GetPageView()
        {
            var result = new List<PageViewRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetPageViewData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult GetPurchase()
        {
            var result = new List<PurchaseRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetPurchaseData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }
        [HttpGet]
        public ActionResult GetSearch()
        {
            var result = new List<SearchRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetSearchData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }

        [HttpGet]
        public ActionResult<SubscribeRModel> GetSubscribe()
        {
            var result = new List<SubscribeRModel>();
            var re = Request;
            var headers = re.Headers;
            var hasToken = false;
            StringValues token = default(StringValues);
            if (headers.ContainsKey("Authorization"))
            {
                hasToken = headers.TryGetValue("Authorization", out token);
            }
            if (hasToken)
            {
                var bytes = Convert.FromBase64String(token);

                var decodedToken = Encoding.UTF8.GetString(bytes);
                if (decodedToken == tokenPwd)
                {
                    result = _TrackLog.GetSubscribeData();
                }
                else
                {
                }
            }
            else
            {
            }

            return new JsonResult(result);
        }



    }
}