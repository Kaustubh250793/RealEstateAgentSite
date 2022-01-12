using RealEstateAgent.Web.Models.ViewModels;
using System.Collections.Specialized;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace RealEstateAgent.Web.Controllers.Surface
{
    public class PropertiesSurfaceController : SurfaceController
    {
        public ActionResult Properties(PropertiesFilterViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var queryString = new NameValueCollection();


            if (!string.IsNullOrWhiteSpace(model.FromPrice))
            {
                queryString.Add("fromPrice", model.FromPrice);
            }

            if (!string.IsNullOrWhiteSpace(model.ToPrice))
            {
                queryString.Add("toPrice", model.ToPrice);
            }

            if (!string.IsNullOrWhiteSpace(model.FromSize))
            {
                queryString.Add("fromSize", model.FromSize);
            }


            if (!string.IsNullOrWhiteSpace(model.ToSize))
            {
                queryString.Add("toSize", model.ToSize);
            }

            return RedirectToCurrentUmbracoPage(queryString);
        }

        public ActionResult MediaPickerGallery(int propId)
        {
            return PartialView("~/Views/Partials/MediaPickerGallery.cshtml", propId);
        }
    }
}