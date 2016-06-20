using ImageGallery.Models;
using System.Linq;
using System.Web.Mvc;

namespace ImageGallery.Controllers
{
    public class HomeController : Controller
    {
        private ImageContext db = new ImageContext();

        public ActionResult Index(string filter = null, int page = 1, int pageSize = 5)
        {
            var records = new PagedList<Image>();
            records.Content = db.Images
                .Where(a => filter == null || (a.name.Contains(filter)))
                .OrderBy(a => a.name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Count
            records.TotalRecords = db.Images
                .Where(a => filter == null || (a.name.Contains(filter))).Count();

            records.CurrentPage = page;
            records.PageSize = pageSize;
            return View(records);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}