using CoreBaseLib.Models;
using Microsoft.Extensions.Configuration;
using SqlLib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBaseLib.Models
{
    public class TrackLogService : ITrackLog
    {
        private readonly IConfiguration _configuration;
        private readonly DbHelper _dbHelper;
        private readonly DapperHelper _dapperHelper;
        public TrackLogService(IConfiguration configuration)
        {
            _configuration = configuration;
            _dapperHelper = new DapperHelper(_configuration);
            _dbHelper = new DbHelper(_configuration);
        }
        // Call API
        public RVal AddtoCartlgAddData(AddtoCartlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "add_to_cart_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }
            return rval;
        }
        public RVal AddPaymentInfolgAddData(AddPaymentInfolgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "add_payment_info_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }
            return rval;
        }

        public RVal AddToWishlistlgAddData(AddToWishlistlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "add_to_wish_list_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }

            return rval;
        }

        public RVal CompleteRegistrationlgAddData(CompleteRegistrationlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "complete_reg_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            return rval;
        }

        public RVal InitiateCheckoutlgAddData(InitiateCheckoutlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "init_checkout_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }

            return rval;
        }

        public RVal PageViewlgAddData(PageViewlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "page_view_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }

        public RVal PurchaselgAddData(PurchaselgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "purchase_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }

            return rval;
        }


        public RVal SearchlgAddData(SearchlgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "search_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);

            if (data.Products.Count > 0)
            {
                foreach (var product in data.Products)
                {
                    var @params = new
                    {
                        eventid = data.eventid,
                        productid = product.productid,
                        quantity = product.quantity
                    };
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (@eventid,@productid,@quantity)";
                    int result = _dapperHelper.ExecuteTransaction(insertSQL, @params);
                }


            }

            return rval;
        }

        public RVal SubscribelgAddData(SubscribelgModel data)
        {
            var cmdHelper = _dbHelper.GetNpgCmdHelper();
            cmdHelper.TableName = "subscribe_lg";
            var cmd = cmdHelper.GetInsertCmd(data);
            var rval = _dbHelper.ExecuteNpgNonQuery(cmd);
            return rval;
        }
        //need change to list
        public List<AddtoCartRModel> GetAddToCartData()
        {
            List<AddtoCartRModel> list = new List<AddtoCartRModel>();

            LockRecordData("add_to_cart_lg");
            var sqlTxt = @"select  * from usp_getaddtocart()";
             var result = _dapperHelper.Query(sqlTxt);

                foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                            pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }

                    list.Add(new AddtoCartRModel() { 
                        eventid = item._eventid,
                        Products = pd,
                        currency = item._currency,
                        total_value = item._total_value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                } );
                
            }
            UpdateCompleteRecord("add_to_cart_lg");
            return list;
        }

        public List<AddPaymentInfoRModel>  GetPaymentInfoData()
        {
            List < AddPaymentInfoRModel> list = new List<AddPaymentInfoRModel>();
  
            LockRecordData("add_payment_info_lg");

            var sqlTxt = @"select  * from usp_getpaymentinfo()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                        pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }

                    list.Add(new AddPaymentInfoRModel()
                    {
                        eventid = item._eventid,
                        Products = pd,
                        currency = item._currency,
                        value = item._value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                    });

            }
            UpdateCompleteRecord("add_payment_info_lg");
            return list;

        }


        public List<AddToWishlistRModel> GetAddToWishListData()
        {
            List < AddToWishlistRModel> list = new List<AddToWishlistRModel>();
 
            LockRecordData("add_to_wish_list_lg");

            var sqlTxt = @"select  * from usp_GetAddToWishList()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                        pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }

                    list.Add(new AddToWishlistRModel()
                    {
                        eventid = item._eventid,
                        Products = pd,
                        currency = item._currency,
                        value = item._value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                    });
            }
            UpdateCompleteRecord("add_to_wish_list_lg");
            return list;
        }


        public List<CompleteRegistrationRModel>  GetCompleteRegistrationData()
        {
            List <CompleteRegistrationRModel> list = new List<CompleteRegistrationRModel>();
            LockRecordData("complete_reg_lg");

            var sqlTxt = @"select  * from usp_GetCompleteRegistration()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {

                list.Add(new CompleteRegistrationRModel()
                {
                    eventid = item._eventid,
                    content_name = item._content_name,
                    reg_status = item._reg_status,
                    currency = item._currency,
                    total_value = item._total_value,
                    email = item._email,
                    first_name = item._first_name,
                    last_name = item._last_name,
                    phone = item._phone,
                    gender = item._gender,
                    DOB = item._dob,
                    city = item._city,
                    state = item._state,
                    country = item._country,
                    user_ip = item._user_ip,
                    browser_user_agent = item._browser_user_agent,
                    clickid = item._clickid,
                    browserid = item._browserid,
                    fb_loginid = item._fb_loginid,
                });
            }
            UpdateCompleteRecord("complete_reg_lg");
            return list;
        }

        public List<InitiateCheckoutRModel>  GetInitiateCheckOutData()
        {
            List<InitiateCheckoutRModel> list = new List<InitiateCheckoutRModel>();
 
            LockRecordData("init_checkout_lg");
            var sqlTxt = @"select  * from usp_GetInitiateCheckOut()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                        pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }
                    list.Add(new InitiateCheckoutRModel()
                    {
                        eventid = item._eventid,
                        Products = pd,
                        currency = item._currency,
                        total_value = item._total_value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                    });
            }
            UpdateCompleteRecord("init_checkout_lg");
            return list;

        }


        public List<PageViewRModel>  GetPageViewData()
        {
            List<PageViewRModel> list = new List<PageViewRModel>();
            LockRecordData("page_view_lg");
            var sqlTxt = @"select  * from usp_GetPageView()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                list.Add(new PageViewRModel()
                {
                    eventid = item._eventid,
                    url = item._url,
                    email = item._email,
                    first_name = item._first_name,
                    last_name = item._last_name,
                    phone = item._phone,
                    gender = item._gender,
                    DOB = item._dob,
                    city = item._city,
                    state = item._state,
                    country = item._country,
                    user_ip = item._user_ip,
                    browser_user_agent = item._browser_user_agent,
                    clickid = item._clickid,
                    browserid = item._browserid,
                    fb_loginid = item._fb_loginid,
                });

                }

            UpdateCompleteRecord("page_view_lg");
            return list;
        }

        public List<PurchaseRModel>  GetPurchaseData()
        {
            List<PurchaseRModel> list = new List<PurchaseRModel>();

            LockRecordData("purchase_lg");
            var sqlTxt = @"select  * from usp_getpurchasedata()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                        pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }
                    list.Add(new PurchaseRModel()
                    {
                        eventid = item._eventid,
                        Products = pd,
                        currency = item._currency,
                        total_value = item._total_value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                    });
            }
            UpdateCompleteRecord("purchase_lg");
            return list;


        }

        public List<SearchRModel>  GetSearchData()
        {
            List<SearchRModel> list = new List<SearchRModel>();

            LockRecordData("search_lg");
            var sqlTxt = @"select  * from usp_GetSearch()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    var pd = new List<Products>();
                    var @params = new { eventid = item._eventid };
                    var sqlProd = @"select  * from usp_getproducts(@eventid)";
                    var ProdResult = _dapperHelper.Query(sqlProd, @params);

                    foreach (var prod in ProdResult)
                    {
                        pd.Add(new Products() { productid = prod._productid, quantity = prod._quantity });
                    }
                    list.Add(new SearchRModel()
                    {
                        eventid = item._eventid,
                        search_str = item._search_str,
                        Products = pd,
                        currency = item._currency,
                        value = item._value,
                        url = item._url,
                        email = item._email,
                        first_name = item._first_name,
                        last_name = item._last_name,
                        phone = item._phone,
                        gender = item._gender,
                        DOB = item._dob,
                        city = item._city,
                        state = item._state,
                        country = item._country,
                        user_ip = item._user_ip,
                        browser_user_agent = item._browser_user_agent,
                        clickid = item._clickid,
                        browserid = item._browserid,
                        fb_loginid = item._fb_loginid,
                    });
            }
            UpdateCompleteRecord("search_lg");
            return list;

        }

        public List<SubscribeRModel>  GetSubscribeData()
        {
            List<SubscribeRModel> list = new List<SubscribeRModel>();
            LockRecordData("subscribe_lg");
            var sqlTxt = @"select  * from usp_GetSubscribe()";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                list.Add(new SubscribeRModel()
                {
                    eventid = item._eventid,
                    predicted_itv = item._predicted_itv,
                    currency = item._currency,
                    value = item._total_value,
                    url = item._url,
                    email = item._email,
                    first_name = item._first_name,
                    last_name = item._last_name,
                    phone = item._phone,
                    gender = item._gender,
                    DOB = item._dob,
                    city = item._city,
                    state = item._state,
                    country = item._country,
                    user_ip = item._user_ip,
                    browser_user_agent = item._browser_user_agent,
                    clickid = item._clickid,
                    browserid = item._browserid,
                    fb_loginid = item._fb_loginid,
                });

            }

            UpdateCompleteRecord("subscribe_lg");
            return list;
        }

        public RVal LockRecordData(String tbl)
        {
            string strUpdate = @"UPDATE "+ tbl  + " set status = 1 where eventid IN( " +
               " select eventid from "+ tbl  + " where COALESCE(status, 0) = 0 ORDER BY createtimestamp asc limit 100) ";
            var rval = _dbHelper.ExecuteNpgNonQuery(strUpdate);
            return rval;
        }
        public RVal UpdateCompleteRecord(String tbl)
        {
            string strUpdate = @"UPDATE " + tbl + " set status = 2 where eventid IN( " +
               " select eventid from " + tbl + " where COALESCE(status, 0) = 1 ORDER BY createtimestamp asc limit 100) ";
            var rval = _dbHelper.ExecuteNpgNonQuery(strUpdate);
            return rval;
        }

        //temp table reset for tiger pistol testing purpose
        public RVal ResetEvents()
        {
            string strUpdate = @"UPDATE add_to_cart_lg set status = 0; " + 
             @"UPDATE add_payment_info_lg set status = 0; " +
            @"UPDATE add_to_wish_list_lg set status = 0;  " +
             @"UPDATE complete_reg_lg set status = 0;  " +
             @"UPDATE init_checkout_lg set status = 0;  " +
             @"UPDATE page_view_lg set status = 0;  " +
             @"UPDATE purchase_lg set status = 0;  " +
             @"UPDATE search_lg set status = 0;  " +
             @"UPDATE subscribe_lg set status = 0;  ";

            var rval = _dbHelper.ExecuteNpgNonQuery(strUpdate);
            return rval;
            
        }
    }
}
