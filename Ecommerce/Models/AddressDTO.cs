using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class AddressDTO
    {

        [Display(Name = "Calle")]

        public string Street { get; set; }

        [Display(Name = "Numero de Calle")]
        public int StreetNumber { get; set; }

        [Display(Name = "Ciudad")]
        public string City { get; set; }

        [Display(Name = "Codigo Postal")]
        public string PostalCode { get; set; }


        [Display(Name = "Apartamento")]
        public string Departament { get; set; }


        [Display(Name = "Estado")]
        public string State { get; set; }
    }
}
