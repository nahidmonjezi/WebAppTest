using System;

namespace WebAppTest.Models.Entities
{
    public sealed class Shop_Address:BaseEntites
    {
        public string shopname { get; set; }
        public string shopManagerName { get; set; }
        public string contry { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string postalcode { get; set; }
        public string email { get; set; }
    }
}