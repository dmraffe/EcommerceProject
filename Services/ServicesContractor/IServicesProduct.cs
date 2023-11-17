using Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesContractor
{
    public interface IServicesProduct 
    {

        public bool AddProduct(Product product);

        public bool UpdateProduct(Product product);

        public bool DeleteProduct(int id);

        public Product GetProductById(int id);

        public List<Product> GetAllProducts();

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> predicated);

    }
}
