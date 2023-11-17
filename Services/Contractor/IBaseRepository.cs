using Domino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contractor
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        public bool Add(T model);

        public bool Update(T model);

        public bool Delete(int Id);

        public List<T> GetAll();

        public T Get(int Id);

        public List<T> GetAll(Expression<Func<T, bool>> predicated);
    }
}
