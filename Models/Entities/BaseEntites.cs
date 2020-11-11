using System;

namespace WebAppTest.Models.Entities
{
    public abstract class BaseEntites
    {
        public Guid  id { get; private set; }
        public virtual  Guid shopid { get;  set; }
        public string title { get; set; }
        public DateTime modified_at { get; private set; }
        public DateTime  created_at { get; private set; }
        
        public BaseEntites()
        {
            id = Guid.NewGuid();
            created_at = DateTime.Now;
            modified_at = DateTime.Now;


        }

    }
}