using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Business.Abstract
{
    public interface IServiceBase<T>where T : class
    {
       public IQueryable<T> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Create(T obj);
        public Task<T> Update(T obj);
        public void Delete(int id);
    }
}
