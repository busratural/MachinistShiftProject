using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Concrete
{

    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity

    {
        private readonly MachinistShiftDbContext _context;

        public ReadRepository(MachinistShiftDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table =>_context.Set<T>();
        
        public IQueryable<T> GetAll()
        => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            =>Table.Where(method);

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => Table.FirstOrDefaultAsync(method);


        public async Task<T> GetByIdAsync(int id)
            =>await Table.FirstOrDefaultAsync(data => data.Id==id);

        public void GetById(int id)
        {
            Table.FindAsync(id);
        }

        //public async Task<T> GetByIdAsync(int id)
        //     => await Table.FindAsync(id);
      
    }
}
