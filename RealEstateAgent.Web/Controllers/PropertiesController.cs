using RealEstateAgent.Web.Models;
using RealEstateAgent.Web.Models.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace RealEstateAgent.Web.Controllers
{
    public class PropertiesController : RenderMvcController
    {
        public ActionResult Index(ContentModel model, string fromSize = "", string toSize = "", string fromPrice = "", string toPrice = "")
        {
            var propertiesContentModel = new PropertiesContentModel(model.Content);

            var propertiesFilterViewModel = new PropertiesFilterViewModel()
            {
                FromPrice = fromPrice,
                ToPrice = toPrice,
                FromSize = fromSize,
                ToSize = toSize
            };

            propertiesContentModel.PropertiesFilterViewModel = propertiesFilterViewModel;

            var existingProperties = propertiesContentModel.Content.Children.Cast<Property>();

            propertiesContentModel.Properties = propertiesContentModel.Content.Children.Cast<Property>();

            if (!string.IsNullOrEmpty(fromPrice) && !string.IsNullOrEmpty(toPrice) && !string.IsNullOrEmpty(fromSize) && !string.IsNullOrEmpty(toSize))
            {
                existingProperties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize) && p.PropertySize <= Convert.ToInt32(toSize)
                && p.PropertyPrice >= Convert.ToInt32(fromPrice) && p.PropertyPrice <= Convert.ToInt32(toPrice));
            }
            else if (!string.IsNullOrEmpty(fromPrice) && !string.IsNullOrEmpty(toPrice))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice >= Convert.ToInt32(fromPrice) && p.PropertyPrice <= Convert.ToInt32(toPrice));
            }
            else if (!string.IsNullOrEmpty(fromSize) && !string.IsNullOrEmpty(toSize))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize) && p.PropertySize <= Convert.ToInt32(toSize));
            }
            else if (!string.IsNullOrEmpty(fromPrice))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice >= Convert.ToInt32(fromPrice));
            }
            else if (!string.IsNullOrEmpty(toPrice))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice <= Convert.ToInt32(toPrice));
            }
            else if (!string.IsNullOrEmpty(fromSize))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize));
            }
            else if (!string.IsNullOrEmpty(toSize))
            {
                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize <= Convert.ToInt32(toSize));
            }

            return CurrentTemplate(propertiesContentModel);
        }
    }
}