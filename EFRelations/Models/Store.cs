using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public class Store
    {
        
        public int ID { get; set; }
        public string storeName { get; set; }
        public string Location { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
         
    }
}