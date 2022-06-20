using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Absract
{ 
    public interface IReadRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        public IQueryable<T> GetAll();
       public IQueryable<T> GetWhere(Expression<Func<T,bool>> method);
       public Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
       public Task<T> GetByIdAsync(int id);
        public void GetById(int İD);
    }
}
