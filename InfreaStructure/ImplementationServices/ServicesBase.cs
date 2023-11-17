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
    public class ServicesBase<T> : IServicesBase<T> where T : BaseModel
    {
        IBaseRepository<T> repository;

        public ServicesBase(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }

        public bool Add(T Entity)
        {
            return this.repository.Add(Entity);
        }

        public bool Delete(int id)
        {
            return this.repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
           return this.repository.GetAll();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicated)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return this.repository.Get(id);
        }

        public bool Update(T Entity)
        {
            return this.repository.Update(Entity);
        }
    }
}
