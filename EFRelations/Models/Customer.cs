using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//this class is created to demonistrate one to many relationship and it is linked with order

namespace EFRelations.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime purchaseDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}