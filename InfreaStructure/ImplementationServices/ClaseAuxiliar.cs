using Domino;
using Services.ServicesContractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfreaStructure.ImplementationServices
{
    public class ClaseAuxiliar<T> : IServicesBase<T> where T : BaseModel
    {
        public bool Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicated)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
