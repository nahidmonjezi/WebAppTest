using System;

namespace WebAppTest.Models.Entities
{
    public abstract class BaseEntites
    {
        public Guid  id { get;  set; }
        public virtual  Guid shopid { get;  set; }
        public string title { get; set; }
        public DateTime modified_at { get; private set; }
        public DateTime  created_at { get; private set; }
        
        public bool Allow_Delete { get; set; }
        public BaseEntites()
        {
            created_at = DateTime.Now;
            modified_at = DateTime.Now;
        }

    }
}