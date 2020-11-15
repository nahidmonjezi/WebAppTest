using System;
using WebAppTest.Models.Entities;

namespace WebAppTest.Models.EntityConfiguration
{
    public class ShopConfiguration:BaseEntityConfiguration<Shop>
    {
        public ShopConfiguration(Guid shopid):base(shopid)
        { 
            
            
        }

        public ShopConfiguration(Guid shopid, DateTime s):this(shopid)
        {
            Guid d= new Guid();
        }
    }
}