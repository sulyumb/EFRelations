using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public class Product
    {
         
        public int ID { get; set; }
        public string productName { get; set;}
        public Decimal price { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
         
    }
}