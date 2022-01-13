using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace RealEstateAgent.Web.Controllers
{
    public class HomeController : SurfaceController
    {
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}