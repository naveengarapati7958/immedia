using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PhotoModel
    {
        [Key]
        public Guid uid { get; set; }
        public string id { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        // Foreign key
        public string venueid { get; set; }

    }
}
