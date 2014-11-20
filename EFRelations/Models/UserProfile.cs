using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//this class is created to demonistrate one to one relation ship and it is linked with UserProfile

namespace EFRelations.Models
{
    public class UserProfile 
    {
        //public int ID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Key, ForeignKey("User")]
        public int userID { get; set; }
        public virtual User User { get; set; }
    }
}