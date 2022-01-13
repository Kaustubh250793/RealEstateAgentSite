using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace RealEstateAgent.Web.Controllers.API
{
    public class PropertiesApiController : UmbracoApiController
    {
        // GET: PropertiesApi
        public IEnumerable<Property> Index(int price)
        {
            var content = UmbracoContext.Content.GetByContentType(UmbracoContext.Content.GetContentType("properties"));

            var children = content.FirstOrDefault().Value<IEnumerable<Property>>("property");

            var props = new List<Property>();
            if (children != null)
            {
                foreach (var child in children)
                {
                    if (child.PropertyPrice <= price)
                    {
                        props.Add(child);   
                    }
                }
            }

            return props;
        }
    }
}