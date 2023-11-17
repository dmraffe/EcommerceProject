using Domino;
using Services.Contractor;
using Services.ServicesContractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfreaStructure.ImplementationServices
{
    public class ServicesProducts : IServicesProduct
    {


        IBaseRepository<Product> baseRepository { get; set; }

        public ServicesProducts(IBaseRepository<Product> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public bool AddProduct(Product product)
        {
            this.baseRepository.Add(product);
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            this.baseRepository.Update(product);
            return true;
        }

        public bool DeleteProduct(int id)
        {
            this.baseRepository.Delete(id);

            return true;
        }

        public Product GetProductById(int id)
        {
          return  this.baseRepository.Get(id);
        }

        public List<Product> GetAllProducts()
        {
          return  this.baseRepository.GetAll();
        }

        public List<Product> GetAllProducts(Expression<Func<Product, bool>> predicated)
        {
            throw new NotImplementedException();
        }
    }
}
