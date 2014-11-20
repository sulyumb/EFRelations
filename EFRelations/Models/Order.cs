using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//this class is created to demonistrate one to many relationship and it is linked with customer as many
// and many to many with stores and products
namespace EFRelations.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderType  { get; set; }
        public decimal price { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
    }
}