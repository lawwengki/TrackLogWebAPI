using Npgsql.TypeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;
using System.Xml;

namespace CoreBaseLib.Models
{
    public class AddToWishlistlgModel
    {
        [Required]
        public long eventid { get; set; }
        public List<Products> Products { get; set; }
        public string currency { get; set; }
        public decimal value { get; set; }
        public string url { get; set; }
        public int type { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        [Required]
        public string browser_sessionid { get; set; }
        public string user_ip { get; set; }
        public string browser_user_agent { get; set; }
        public string clickid { get; set; }
        public string browserid { get; set; }
        public string fb_loginid { get; set; }
        public DateTime createtimestamp { get; set; }

        public int status { get; set; }

    }
}
