using Npgsql.TypeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;
using System.Xml;

namespace CoreBaseLib.Models
{
    public class PageViewlgModel
    {
        [Required]
        public long eventid { get; set; }
        [Required]
        public string url { get; set; }
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
        public long browser_sessionid { get; set; }
        public string user_ip { get; set; }
        public string browser_user_agent { get; set; }
        public string clickid { get; set; }
        public string browserid { get; set; }
        public string fb_loginid { get; set; }
        public DateTime createtimestamp { get; set; }

        public int status { get; set; }

    }
}
