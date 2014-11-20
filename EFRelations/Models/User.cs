using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//this class is created to demonistrate one to one relation ship and it is linked with UserProfile
namespace EFRelations.Models
{
    public class User 
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
        public virtual UserProfile UserProfile { get; set; }
    }
}