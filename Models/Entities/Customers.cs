namespace WebAppTest.Models.Entities
{
    public sealed class Customers:BaseEntites
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mail_address { get; set; }
        public string tel { get; set; }
    }
}