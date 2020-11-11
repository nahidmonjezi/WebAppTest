using System;

namespace WebAppTest.Models.Entities
{
    public sealed class Constant:BaseEntites
    {
        public Guid parent_id { get; set; }
        public string value1 { get; set; }
        public string value2 { get; set; }
        public string value3 { get; set; }
    }
}