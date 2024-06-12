using System.ComponentModel.DataAnnotations;

namespace AlloyCheck.Models.Blocks
{
    [ContentType(
        DisplayName = "Event Item",
        GUID = "5D02F4A4-0D82-4F73-A99B-9D9A8FA90D53",
        Description = "Block for representing an event item.")]
    public class EventItemBlock : BlockData
    {
        [Display(
            Name = "Title",
            Description = "The title of the event.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Image URL",
            Description = "The URL of the event image.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string ImageUrl { get; set; }

        [Display(
            Name = "Description",
            Description = "Description of the event.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Registration Link",
            Description = "The link for event registration.",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string RegistrationLink { get; set; }
    }
}
