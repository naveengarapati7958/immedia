using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class VenueModel
    {
        [Key]
        public Guid uid { get; set; }
        public string id { get; set; }
        public string name { get; set; }

        // Navigation property
        //public virtual ICollection<PhotoModel> Photos { get; private set; }
    }
}
