using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImageGallery.Models
{
    public class ImageContext : DbContext
    {
        public ImageContext() : base("DefaultConnection") { }
        public DbSet<Images> Images { get; set; }
    }
}