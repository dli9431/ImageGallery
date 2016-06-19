using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageGallery.Models
{
    public class Images
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string image { get; set; }

    }
}