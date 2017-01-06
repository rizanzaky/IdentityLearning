using System.Collections.Generic;
using System.Web.Mvc;

namespace SecurityApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Dictionary<string, object> data = new Dictionary<string, object>("Placeholder", "Placeholder");
            data.Add("Placeholder", "Placeholder");

            return View(data);
        }
    }
}