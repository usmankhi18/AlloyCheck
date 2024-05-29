namespace AlloyCheck.Models.Pages
{
    [ContentType(DisplayName = "CustomPage", GUID = "e5d7bd42-cf69-4304-a487-28c3f523437d", Description = "A custom page type")]
    public class CustomPage : SitePageData
    {
        public virtual string Title { get; set; }
        public virtual XhtmlString MainBody { get; set; }
        public virtual ContentArea ContentArea { get; set; }
        public virtual ContentArea ContentArea1 { get; set; }
        public virtual ContentArea ContentArea2 { get; set; }
    }
}
