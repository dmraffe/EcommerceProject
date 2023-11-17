using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class AddressDTI
    {
        [Display(Name = "Nombre de la Calle :")]
        [Required (ErrorMessage ="Por favor ingrese este dato")]
        public string Street { get; set; }

        [Display(Name = "Numero de la Calle :")]
        [Range(0, 1000,ErrorMessage ="El numero de calle no puede ser menor a 1000")]
        [Required(ErrorMessage = "Por favor ingrese este dato")]
        public int StreetNumber { get; set; }

        [Display(Name = "Ciudad :")]
        [Required(ErrorMessage = "Por favor ingrese este dato")]
        public string City { get; set; }

        [Display(Name = "Codigo Postal :")]
        [Required(ErrorMessage = "Por favor ingrese este dato")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }


        [Display(Name = "# de Apartamento :")]
        [Required(ErrorMessage = "Por favor ingrese este dato")]
        public string Departament { get; set; }


        [Display(Name = "Estado :")]
        [Required(ErrorMessage = "Por favor ingrese este dato")]
        public string State { get; set; }
    }
}
