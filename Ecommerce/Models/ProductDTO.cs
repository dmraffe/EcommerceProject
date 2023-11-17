using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class ProductDTO
    {
 
        public int Id { get; set; } 
        public string Nombre { get; set; }

      
        public string Description { get; set; }
     
        public decimal Price { get; set; }

       
        public int Quantity { get; set; }

        public string Code { get; set; }
    }
}
