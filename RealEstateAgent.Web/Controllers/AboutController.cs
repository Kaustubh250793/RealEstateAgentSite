//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Umbraco.Web.Mvc;

//namespace RealEstateAgent.Web.Controllers
//{
//    public class AboutController : RenderMvcController
//    {
//        // GET: About
//        public ActionResult Index()
//        {
//            var propertiesContentModel = new PropertiesContentModel(model.Content);

//            var propertiesFilterViewModel = new PropertiesFilterViewModel()
//            {
//                FromPrice = fromPrice,
//                ToPrice = toPrice,
//                FromSize = fromSize,
//                ToSize = toSize
//            };

//            propertiesContentModel.PropertiesFilterViewModel = propertiesFilterViewModel;

//            var existingProperties = propertiesContentModel.Content.Children.Cast<Property>();

//            propertiesContentModel.Properties = propertiesContentModel.Content.Children.Cast<Property>();

//            if (!string.IsNullOrEmpty(fromPrice) && !string.IsNullOrEmpty(toPrice) && !string.IsNullOrEmpty(fromSize) && !string.IsNullOrEmpty(toSize))
//            {
//                existingProperties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize) && p.PropertySize <= Convert.ToInt32(toSize)
//                && p.PropertyPrice >= Convert.ToInt32(fromPrice) && p.PropertyPrice <= Convert.ToInt32(toPrice));
//            }
//            else if (!string.IsNullOrEmpty(fromPrice) && !string.IsNullOrEmpty(toPrice))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice >= Convert.ToInt32(fromPrice) && p.PropertyPrice <= Convert.ToInt32(toPrice));
//            }
//            else if (!string.IsNullOrEmpty(fromSize) && !string.IsNullOrEmpty(toSize))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize) && p.PropertySize <= Convert.ToInt32(toSize));
//            }
//            else if (!string.IsNullOrEmpty(fromPrice))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice >= Convert.ToInt32(fromPrice));
//            }
//            else if (!string.IsNullOrEmpty(toPrice))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertyPrice <= Convert.ToInt32(toPrice));
//            }
//            else if (!string.IsNullOrEmpty(fromSize))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize >= Convert.ToInt32(fromSize));
//            }
//            else if (!string.IsNullOrEmpty(toSize))
//            {
//                propertiesContentModel.Properties = existingProperties.Where(p => p.PropertySize <= Convert.ToInt32(toSize));
//            }

//            return CurrentTemplate(propertiesContentModel);
//        }
//    }
//}