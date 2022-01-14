using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace RealEstateAgent.Web.Controllers.API
{
    public class PropertiesApiController : UmbracoApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            var content = UmbracoContext.Content.GetByContentType(UmbracoContext.Content.GetContentType("properties"));

            var properties = content.FirstOrDefault().Children.Cast<Property>();
            var model = new List<PropertiesJsonModel>();
            if (properties != null)
            {
                foreach (var child in properties)
                {
                    model.Add(new PropertiesJsonModel()
                    {
                        Id = child.Id,
                        Address = child.PropertyAddress,
                        Price = child.PropertyPrice,
                        Size = child.PropertySize,
                        LastPosted = child.LastPosted,
                        Owner = child.PropertyOwner
                    });
                }
            }

            return Json(new { data = model });
        }
    }
}