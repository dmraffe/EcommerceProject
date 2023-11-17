using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Ecommerce.Models
{
    public class ProductDTIN
    {

        [Required(ErrorMessage ="Pone el dato pelo.... ")]
         
        [Display(Name = "Product Name")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [RegularExpression("^[0-9]+$")]
        public decimal Price { get; set; }

        [Range(0, 150)]
        public int Quantity { get; set; }

        public string Code { get; set; }



    }
}
