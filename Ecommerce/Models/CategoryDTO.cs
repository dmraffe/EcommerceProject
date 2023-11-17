using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class CategoryDTO
    {

        public int Id { get; set; }


        [Display(Name = "Nombre de la Categoria")]
        [Required]
        public string Nombre { get; set; }


        [Display(Name = "Descripcion de la Categoria")]
        [Required]
        public string Descripcion { get; set; }
    }
}
