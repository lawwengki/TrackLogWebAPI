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
        
        public AddtoCartRModel GetAddToCartData()
        {
            AddtoCartRModel list = new AddtoCartRModel();
            long tempid = 0;
            LockRecordData("add_to_cart_lg");
            var sqlTxt = @"SELECT *
                                    FROM add_to_cart_lg  inner join products ON add_to_cart_lg.eventid = products.eventid 
                                    WHERE status = 1 order by createtimestamp asc";
             var result = _dapperHelper.Query(sqlTxt);

                foreach (var item in result)
            {
                if (tempid == 0 || tempid != item.eventid) { 
                list = new AddtoCartRModel();
                var pd = new List<Products>();
                list.eventid = item.eventid;
                foreach (var prod in result)
                {
                        if (prod.eventid == item.eventid)
                        {
                            pd.Add(new Products() { productid = prod.productid, quantity = prod.quantity });
                        }
                        else {
                            break;
                        }
                    }
                    list.Products = pd;
                    list.currency = item.currency;
                    list.total_value = item.total_value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("add_to_cart_lg");
            return list;
        }

        public AddPaymentInfoRModel  GetPaymentInfoData()
        {
            AddPaymentInfoRModel list = new AddPaymentInfoRModel();
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
                    list = new AddPaymentInfoRModel();
                    var pd = new List<Products>();
                    list.eventid = item.eventid;
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
                    list.Products = pd;
                    list.currency = item.currency;
                    list.value = item.value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("add_payment_info_lg");
            return list;

        }


        public AddToWishlistRModel GetAddToWishListData()
        {
            AddToWishlistRModel list = new AddToWishlistRModel();
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
                    list = new AddToWishlistRModel();
                    var pd = new List<Products>();
                    list.eventid = item.eventid;
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
                    list.Products = pd;
                    list.currency = item.currency;
                    list.value = item.value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("add_to_wish_list_lg");
            return list;
        }


        public CompleteRegistrationRModel  GetCompleteRegistrationData()
        {
            CompleteRegistrationRModel list = new CompleteRegistrationRModel();
            LockRecordData("complete_reg_lg");
            var sqlTxt = @"SELECT * FROM complete_reg_lg WHERE status = 1  order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                list = new CompleteRegistrationRModel();
                list.eventid = item.eventid;
                list.content_name = item.content_name;
                list.reg_status = item.reg_status;
                list.currency = item.currency;
                list.total_value = item.total_value;
                list.email = item.email;
                list.first_name = item.first_name;
                list.last_name = item.last_name;
                list.phone = item.phone;
                list.gender = item.gender;
                list.DOB = item.dob;
                list.city = item.city;
                list.state = item.state;
                list.country = item.country;
                list.user_ip = item.user_ip;
                list.browser_user_agent = item.browser_user_agent;
                list.clickid = item.clickid;
                list.state = item.state;
                list.clickid = item.clickid;
                list.browserid = item.browserid;
                list.fb_loginid = item.fb_loginid;
            }
            UpdateCompleteRecord("complete_reg_lg");
            return list;
        }

        public InitiateCheckoutRModel  GetInitiateCheckOutData()
        {
            InitiateCheckoutRModel list = new InitiateCheckoutRModel();
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
                    list = new InitiateCheckoutRModel();
                    var pd = new List<Products>();
                    list.eventid = item.eventid;
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
                    list.Products = pd;
                    list.currency = item.currency;
                    list.total_value = item.total_value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("init_checkout_lg");
            return list;

        }


        public PageViewRModel  GetPageViewData()
        {
            PageViewRModel list = new PageViewRModel();
            LockRecordData("page_view_lg");
            var sqlTxt = @"SELECT * FROM page_view_lg WHERE status = 1  order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                    list = new PageViewRModel();
                    list.eventid = item.eventid;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }

            UpdateCompleteRecord("page_view_lg");
            return list;
        }

        public PurchaseRModel  GetPurchaseData()
        {
            PurchaseRModel list = new PurchaseRModel();
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
                    list = new PurchaseRModel();
                    var pd = new List<Products>();
                    list.eventid = item.eventid;
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
                    list.Products = pd;
                    list.currency = item.currency;
                    list.total_value = item.total_value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("purchase_lg");
            return list;


        }

        public SearchRModel  GetSearchData()
        {
            SearchRModel list = new SearchRModel();
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
                    list = new SearchRModel();
                    var pd = new List<Products>();
                    list.eventid = item.eventid;
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
                    list.Products = pd;
                    list.currency = item.currency;
                    list.value = item.value;
                    list.url = item.url;
                    list.email = item.email;
                    list.first_name = item.first_name;
                    list.last_name = item.last_name;
                    list.phone = item.phone;
                    list.gender = item.gender;
                    list.DOB = item.dob;
                    list.city = item.city;
                    list.state = item.state;
                    list.country = item.country;
                    list.user_ip = item.user_ip;
                    list.browser_user_agent = item.browser_user_agent;
                    list.clickid = item.clickid;
                    list.state = item.state;
                    list.clickid = item.clickid;
                    list.browserid = item.browserid;
                    list.fb_loginid = item.fb_loginid;
                }
                tempid = item.eventid;
            }
            UpdateCompleteRecord("search_lg");
            return list;

        }

        public SubscribeRModel  GetSubscribeData()
        {
            SubscribeRModel list = new SubscribeRModel();
            LockRecordData("subscribe_lg");
            var sqlTxt = @"SELECT * FROM subscribe_lg WHERE status = 1 order by createtimestamp asc  ";
            var result = _dapperHelper.Query(sqlTxt);

            foreach (var item in result)
            {
                list = new SubscribeRModel();
                list.eventid = item.eventid;
                list.predicted_itv = item.predicted_itv;
                list.currency = item.currency;
                list.value = item.value;
                list.url = item.url;
                list.email = item.email;
                list.first_name = item.first_name;
                list.last_name = item.last_name;
                list.phone = item.phone;
                list.gender = item.gender;
                list.DOB = item.dob;
                list.city = item.city;
                list.state = item.state;
                list.country = item.country;
                list.user_ip = item.user_ip;
                list.browser_user_agent = item.browser_user_agent;
                list.clickid = item.clickid;
                list.state = item.state;
                list.clickid = item.clickid;
                list.browserid = item.browserid;
                list.fb_loginid = item.fb_loginid;
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

    }
}
