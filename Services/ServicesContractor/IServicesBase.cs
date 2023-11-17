using Domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesContractor
{
    public interface IServicesBase<T> where T : BaseModel
    {
        public bool Add(T Entity);

        public bool Update(T Entity);

        public bool Delete(int id);

        public T GetById(int id);

        public IEnumerable<T> GetAll();

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicated);

    }
}
