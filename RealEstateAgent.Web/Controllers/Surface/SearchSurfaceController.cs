using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Collections.Specialized;
using RealEstateAgent.Web.Models.ViewModels;

namespace RealEstateAgent.Web.Controllers.Surface
{
    public class SearchSurfaceController : SurfaceController
    {
        public ActionResult SubmitForm(ExamineSearchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var queryString = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(model.Query))
            {
                queryString.Add("query", model.Query);
            }

            if (!string.IsNullOrWhiteSpace(model.Category))
            {
                queryString.Add("category", model.Category);
            }

            if (!string.IsNullOrWhiteSpace(model.Page))
            {
                queryString.Add("page", model.Page);
            }

            return RedirectToCurrentUmbracoPage(queryString);
        }

        public ActionResult RenderForm(ExamineSearchViewModel model)
        {
            return PartialView("Partials/SearchForm", model);
        }
    }
}