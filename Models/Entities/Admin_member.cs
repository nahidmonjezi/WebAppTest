namespace WebAppTest.Models.Entities
{
    public sealed class Admin_member:BaseEntites
    {
        public string username { get; set; }
        public string password { get; set; }
        public string mail_address { get; set; }
        public int role { get; set; }
    }
}