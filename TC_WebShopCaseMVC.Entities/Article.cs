﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TC_WebShopCaseMVC.Entities
{
    [Serializable]
    public class Article
    {
        
        public string Title { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid e-mail address")]
        public string Email { get; set; }
        public string City { get; set; }
        [DisplayName("Zip code")]
        public string ZipCode { get; set; }
        [DisplayName("House number")]
        public int HouseNumber { get; set; }
    }
}
