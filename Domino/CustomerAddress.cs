using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class CustomerAddres : BaseModel
    {
        public string Street {  get; set; }
        public int StreetNumber {  get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string Departament { get; set; }

        public string State { get; set; }
    }
}
