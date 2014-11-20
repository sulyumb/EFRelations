using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFRelations.Models
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModeifiedDate { get; set; }
        public string IP { get; set; }

    }
}