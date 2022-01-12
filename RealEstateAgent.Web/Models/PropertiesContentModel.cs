using RealEstateAgent.Web.Models.ViewModels;
using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace RealEstateAgent.Web.Models
{
    public class PropertiesContentModel : ContentModel
    {
        public PropertiesContentModel(IPublishedContent content) 
            : base(content)
        {
        }

        public PropertiesFilterViewModel PropertiesFilterViewModel { get; set; }

        public IEnumerable<Property> Properties { get; set; }
    }
}