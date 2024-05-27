using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace AlloyCheck.Models.Blocks
{
    [ContentType(DisplayName = "Image Slider", GUID = "D1B3E62A-224E-4F2D-BD2A-DFDAE27E72DE", Description = "Block for displaying an image slider.")]
    public class ImageSliderBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Images", Description = "Images for the image slider.")]
        [UIHint(UIHint.Image)]
        public virtual ContentArea Images { get; set; }

        [Display(Name = "Auto Play", Description = "Enable auto play for the image slider.")]
        public virtual bool AutoPlay { get; set; }

        [Display(Name = "Interval (ms)", Description = "Interval between slides in milliseconds.")]
        public virtual int Interval { get; set; } = 5000; // Default interval of 5 seconds

        // Add more properties as needed

        [Display(Name = "Music", Description = "Background Music.")]
        [UIHint(UIHint.MediaFile)]
        public virtual ContentReference Music { get; set; }
    }
}
