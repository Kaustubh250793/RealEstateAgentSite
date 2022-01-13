using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace RealEstateAgent.Web.Models
{
    public class AboutContentModel : ContentModel
    {
        public AboutContentModel(IPublishedContent content)
            : base(content)
        {
        }

        public HtmlString AboutDescription { get; set; }

        //public HtmlString AboutDescription { get; set; }
    }
}