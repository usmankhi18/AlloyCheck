using System.Linq;
using AlloyCheck.Controllers;
using AlloyCheck.Models.Pages;
using AlloyCheck.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.UnifiedSearch;
using Microsoft.AspNetCore.Mvc;

namespace AlloyCheck.Controllers
{
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        private readonly IClient searchClient;
        public SearchPageController(IClient searchClient)
        {
            this.searchClient = searchClient;
        }
        public ViewResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchContentModel(currentPage)
            {
                Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
                NumberOfHits = 0,
                SearchServiceDisabled = false,
                SearchedQuery = q
            };
            if (!string.IsNullOrWhiteSpace(q))
            {
                UnifiedSearchResults results = searchClient
                .UnifiedSearchFor(q).GetResult();
                model.Hits = results.Hits.Select(hit =>
                new SearchContentModel.SearchHit()
                {
                    Title = hit.Document.Title,
                    Url = hit.Document.Url,
                    Excerpt = hit.Document.Excerpt
                });
                model.NumberOfHits = results.TotalMatching;
            }
            return View(model);

        }
    }
}