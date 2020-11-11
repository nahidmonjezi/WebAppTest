using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppTest.Models.Entities
{
    public sealed class shop_pic:BaseEntites
    {
        [NotMapped]
        public override Guid shopid { get; set; }
        public byte binary { get; set; }
        public string extension { get; set; }
    }
}