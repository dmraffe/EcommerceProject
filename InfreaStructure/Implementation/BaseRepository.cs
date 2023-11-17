
using Domino;
using InfreaStructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfreaStructure.Implementation
{
    public class BaseRepository<T> : Services.Contractor.IBaseRepository<T> where T : BaseModel
    {
        EcommerceDbContext ecommerceDbContext;
        public BaseRepository(EcommerceDbContext _ecommerceDbContext) {
            ecommerceDbContext = _ecommerceDbContext;
        }

        public bool Add(T model)
        {
            ecommerceDbContext.Add(model);
            ecommerceDbContext.SaveChanges();
            return true;
        }

        public bool Delete(int Id)
        {
            var Entidad = Get(Id);
            ecommerceDbContext.Set<T>().Remove(Entidad);
            ecommerceDbContext.SaveChanges();
            return true;
        }

        public T Get(int Id)
        {
            return ecommerceDbContext.Set<T>().Where(a =>a.Id==Id).FirstOrDefault();
        }

        public List<T> GetAll()
        {
         return   ecommerceDbContext.Set <T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicated)
        {
            throw new NotImplementedException();
        }

        public bool Update(T model)
        {
            ecommerceDbContext.Update(model);
            ecommerceDbContext.SaveChanges();

            return true;
        }
    }
}
