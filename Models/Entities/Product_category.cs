using System;

namespace WebAppTest.Models.Entities
{
    public sealed class Product_category:BaseEntites
    {
        public Guid parent_id { get; set; }
    }
}