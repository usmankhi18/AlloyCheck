using AlloyCheck.Models.Pages;
using AlloyCheck.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyCheck.Controllers
{
    [TemplateDescriptor(TemplateTypeCategory = TemplateTypeCategories.MvcController)]
    public class CustomPageController : PageController<CustomPage>
    {
        public ActionResult Index(CustomPage currentPage)
        {
            return View(PageViewModel.Create(currentPage));
        }
    }
}
