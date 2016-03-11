using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TC_WebShopCaseMVC.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int HouseNumber { get; set; }
    }
}