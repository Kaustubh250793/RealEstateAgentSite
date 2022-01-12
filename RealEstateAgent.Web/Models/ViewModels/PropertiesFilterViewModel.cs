using System.ComponentModel.DataAnnotations;

namespace RealEstateAgent.Web.Models.ViewModels
{
    public class PropertiesFilterViewModel
    {
        [Display(Name = "From Price")]
        public string FromPrice { get; set; }

        [Display(Name = "To Price")]
        public string ToPrice { get; set; }

        [Display(Name = "From Size")]
        public string FromSize { get; set; }

        [Display(Name = "To Size")]
        public string ToSize { get; set; }
    }
}