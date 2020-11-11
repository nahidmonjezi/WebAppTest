using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebAppTest.Models.Entities
{
    public sealed class Customers_address:BaseEntites
    {
        public string country { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string postal_code { get; set; }
    }
}