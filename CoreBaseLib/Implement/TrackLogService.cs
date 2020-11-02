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

            if(data.Products.Count> 0) {
                foreach (var product in data.Products)
                {
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() +","+ product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() + "," + product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() + "," + product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() + "," + product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() + "," + product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
                    string insertSQL = "INSERT INTO products(eventid, productid, quantity) VALUES (" +
                        data.eventid.ToString() + "," + product.productid.ToString() + "," + product.quantity.ToString() + ")";
                    rval = _dbHelper.ExecuteNpgNonQuery(insertSQL);
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
            long tempid = 0;
            LockRecordData("add_to_cart_lg");
            var sqlTxt = @"SELECT *
                                    FROM add_to_cart_lg  inner join products ON add_to_cart_lg.eventid = products.eventid 
                                    WHERE status = 1 order by add_to_cart_lg.eventid, createtimestamp asc";
             var result = _dapperHelper.Query(sqlTxt);

                foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid) { 
              //  list = new List<AddtoCartRModel>();
                var pd = new List<Products>();

                foreach (var prod in result)
                {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else {
                           //  need create a temp
                            //break;
                        }
                    }

                    list.Add(new AddtoCartRModel() { 
                        eventid = item.eventid,
                        Products = pd,
                        currency = item.currency,
                        total_value = item.total_value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                } );
                tempid = item.eventid;
            }
                
            }
            UpdateCompleteRecord("add_to_cart_lg");
            return list;
        }

        public List<AddPaymentInfoRModel>  GetPaymentInfoData()
        {
            List < AddPaymentInfoRModel> list = new List<AddPaymentInfoRModel>();
            long tempid = 0;
            LockRecordData("add_payment_info_lg");
            var sqlTxt = @"SELECT *
                                    FROM add_payment_info_lg  inner join products ON add_payment_info_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid)
                {
                   // list = new AddPaymentInfoRModel();
                    var pd = new List<Products>();
                  //  list.eventid = item.eventid;
                    foreach (var prod in result)
                    {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else
                        {
                         //   break;
                        }
                    }

                    list.Add(new AddPaymentInfoRModel()
                    {
                        eventid = item.eventid,
                        Products = pd,
                        currency = item.currency,
                        value = item.value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                    });
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("add_payment_info_lg");
            return list;

        }


        public List<AddToWishlistRModel> GetAddToWishListData()
        {
            List < AddToWishlistRModel> list = new List<AddToWishlistRModel>();
            long tempid = 0;
            LockRecordData("add_to_wish_list_lg");
            var sqlTxt = @"SELECT *
                                    FROM add_to_wish_list_lg  inner join products ON add_to_wish_list_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid)
                {
                //    list = new AddToWishlistRModel();
                    var pd = new List<Products>();
                  //  list.eventid = item.eventid;
                    foreach (var prod in result)
                    {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else
                        {
                            break;
                        }
                    }
                    list.Add(new AddToWishlistRModel()
                    {
                        eventid = item.eventid,
                        Products = pd,
                        currency = item.currency,
                        value = item.value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                    });
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("add_to_wish_list_lg");
            return list;
        }


        public List<CompleteRegistrationRModel>  GetCompleteRegistrationData()
        {
            List <CompleteRegistrationRModel> list = new List<CompleteRegistrationRModel>();
            LockRecordData("complete_reg_lg");
            var sqlTxt = @"SELECT * FROM complete_reg_lg WHERE status = 1  order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                //    list = new CompleteRegistrationRModel();
                list.Add(new CompleteRegistrationRModel()
                {
                    eventid = item.eventid,
                    content_name = item.content_name,
                    reg_status = item.reg_status,
                    currency = item.currency,
                    total_value = item.total_value,
                    email = item.email,
                    first_name = item.first_name,
                    last_name = item.last_name,
                    phone = item.phone,
                    gender = item.gender,
                    DOB = item.dob,
                    city = item.city,
                    state = item.state,
                    country = item.country,
                    user_ip = item.user_ip,
                    browser_user_agent = item.browser_user_agent,
                    clickid = item.clickid,
                    browserid = item.browserid,
                    fb_loginid = item.fb_loginid,
                });
            }
            UpdateCompleteRecord("complete_reg_lg");
            return list;
        }

        public List<InitiateCheckoutRModel>  GetInitiateCheckOutData()
        {
            List<InitiateCheckoutRModel> list = new List<InitiateCheckoutRModel>();
            long tempid = 0;
            LockRecordData("init_checkout_lg");
            var sqlTxt = @"SELECT *
                                    FROM init_checkout_lg  inner join products ON init_checkout_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid)
                {
                //    list = new InitiateCheckoutRModel();
                    var pd = new List<Products>();
                    foreach (var prod in result)
                    {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else
                        {
                            break;
                        }
                    }
                    list.Add(new InitiateCheckoutRModel()
                    {
                        eventid = item.eventid,
                        Products = pd,
                        currency = item.currency,
                        total_value = item.total_value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                    });
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("init_checkout_lg");
            return list;

        }


        public List<PageViewRModel>  GetPageViewData()
        {
            List<PageViewRModel> list = new List<PageViewRModel>();
            LockRecordData("page_view_lg");
            var sqlTxt = @"SELECT * FROM page_view_lg WHERE status = 1  order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                list.Add(new PageViewRModel()
                {
                    eventid = item.eventid,
                    url = item.url,
                    email = item.email,
                    first_name = item.first_name,
                    last_name = item.last_name,
                    phone = item.phone,
                    gender = item.gender,
                    DOB = item.dob,
                    city = item.city,
                    state = item.state,
                    country = item.country,
                    user_ip = item.user_ip,
                    browser_user_agent = item.browser_user_agent,
                    clickid = item.clickid,
                    browserid = item.browserid,
                    fb_loginid = item.fb_loginid,
                });

                }

            UpdateCompleteRecord("page_view_lg");
            return list;
        }

        public List<PurchaseRModel>  GetPurchaseData()
        {
            List<PurchaseRModel> list = new List<PurchaseRModel>();
            long tempid = 0;
            LockRecordData("purchase_lg");
            var sqlTxt = @"SELECT *
                                    FROM purchase_lg  inner join products ON purchase_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid)
                {
                  // list = new PurchaseRModel();
                    var pd = new List<Products>();
                  //  list.eventid = item.eventid;
                    foreach (var prod in result)
                    {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else
                        {
                            break;
                        }
                    }
                    list.Add(new PurchaseRModel()
                    {
                        eventid = item.eventid,
                        Products = pd,
                        currency = item.currency,
                        total_value = item.total_value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                    });
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("purchase_lg");
            return list;


        }

        public List<SearchRModel>  GetSearchData()
        {
            List<SearchRModel> list = new List<SearchRModel>();
            long tempid = 0;
            LockRecordData("search_lg");
            var sqlTxt = @"SELECT *
                                    FROM search_lg  inner join products ON search_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid)
                {
                   // list = new SearchRModel();
                    var pd = new List<Products>();
                   // list.eventid = item.eventid;
                    foreach (var prod in result)
                    {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else
                        {
                            break;
                        }
                    }
                    list.Add(new SearchRModel()
                    {
                        eventid = item.eventid,
                        search_str = item.search_str,
                        Products = pd,
                        currency = item.currency,
                        value = item.value,
                        url = item.url,
                        email = item.email,
                        first_name = item.first_name,
                        last_name = item.last_name,
                        phone = item.phone,
                        gender = item.gender,
                        DOB = item.dob,
                        city = item.city,
                        state = item.state,
                        country = item.country,
                        user_ip = item.user_ip,
                        browser_user_agent = item.browser_user_agent,
                        clickid = item.clickid,
                        browserid = item.browserid,
                        fb_loginid = item.fb_loginid,
                    });
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("search_lg");
            return list;

        }

        public List<SubscribeRModel>  GetSubscribeData()
        {
            List<SubscribeRModel> list = new List<SubscribeRModel>();
            LockRecordData("subscribe_lg");
            var sqlTxt = @"SELECT * FROM subscribe_lg WHERE status = 1 order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                //list = new SubscribeRModel();

                list.Add(new SubscribeRModel()
                {
                    eventid = item.eventid,
                    predicted_itv = item.predicted_itv,
                    currency = item.currency,
                    value = item.value,
                    url = item.url,
                    email = item.email,
                    first_name = item.first_name,
                    last_name = item.last_name,
                    phone = item.phone,
                    gender = item.gender,
                    DOB = item.dob,
                    city = item.city,
                    state = item.state,
                    country = item.country,
                    user_ip = item.user_ip,
                    browser_user_agent = item.browser_user_agent,
                    clickid = item.clickid,
                    browserid = item.browserid,
                    fb_loginid = item.fb_loginid,
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
