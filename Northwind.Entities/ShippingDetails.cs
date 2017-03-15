using System.ComponentModel.DataAnnotations;

namespace Northwind.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Zorunlu ALan")]   
        [Display(Name = "Ad Soyad")]     
        public string Name { get; set; }

        [Required(ErrorMessage = "Zorunlu ALan")]
        [MinLength(10)]
        [MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string Address3 { get; set; }

        [Required(ErrorMessage = "Zorunlu ALan")]
        [MinLength(3)]
        [MaxLength(50)]
        public string City { get; set; }
        
        public string Country { get; set; }
 
        public string IsGift { get; set; }

        public ShippingDetails()
        {

        }
    }
}
 