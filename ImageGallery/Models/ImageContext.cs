using System;
using System.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ImageGallery.Models;

namespace ImageGallery.Models
{
    public class ImageContext : DbContext
    {
        public ImageContext() : base("DefaultConnection") { }
        public DbSet<Image> Images { get; set; }
    }
}