using AlloyCheck.Models.Pages;
using AlloyCheck.Models.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AlloyCheck.Components
{
    public class ProductPagePartialComponent : PartialContentComponent<ProductPage>
    {
        protected override IViewComponentResult InvokeComponent(ProductPage currentPage)
        {
            
            return View(PageViewModel.Create(currentPage));
        }
    }

}
