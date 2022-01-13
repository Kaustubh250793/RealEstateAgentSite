using RealEstateAgent.Web.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace RealEstateAgent.Web.Models
{
    public class ExamineSearchPageModel : ContentModel
    {
        public ExamineSearchPageModel(IPublishedContent content) : base(content)
        {

        }

        public ExamineSearchViewModel SearchViewModel { get; set; }

        public IEnumerable<IPublishedContent> SearchResults { get; set; }
    }
}