using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppTest.Models.Entities
{
    [Table("ShopTBL")]
    public class Shop:BaseEntites
    {
        [NotMapped]
        public override Guid shopid { get; set; }
        public string owner_mail_address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string postal_code { get; set; }
    }
}