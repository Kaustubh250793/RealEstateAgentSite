using RealEstateAgent.Web.Models;
using RealEstateAgent.Web.Models.ViewModels;
using RealEstateAgent.Web.Services;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace RealEstateAgent.Web.Controllers
{
    public class SearchPageController : RenderMvcController
    {
        private readonly ISearchService _searchService;
        private readonly IDataTypeValueService _dataTypeValueService;
        public string[] DocTypeAliases { get; set; }

        public SearchPageController(ISearchService searchService, IDataTypeValueService dataTypeValueService)
        {
            _searchService = searchService;
            _dataTypeValueService = dataTypeValueService;
            DocTypeAliases = new[] { "about", "properties" };
        }

        public ActionResult Index(ContentModel model, string query, string page, string category)
        {
            var searchPageModel = new ExamineSearchPageModel(model.Content);

            var searchViewModel = new ExamineSearchViewModel()
            {
                Query = query,
                Category = category,
                Page = page
            };

            if (!int.TryParse(page, out var pageNumber))
            {
                pageNumber = 1;
            }

            var searchResults = _searchService.GetPageOfContentSearchResults(query, category,
                pageNumber, out var DocTypeAliases, null);

            searchPageModel.SearchViewModel = searchViewModel;
            searchPageModel.SearchResults = searchResults;

            return CurrentTemplate(searchPageModel);
        }
    }
}