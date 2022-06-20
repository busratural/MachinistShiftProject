using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Concrete
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private MachinistShiftDbContext _context;

        public WriteRepository(MachinistShiftDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry= await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry =  Table.Remove(model);
            
            return entityEntry.State == EntityState.Deleted;

        }
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }
        public void Delete(int id)

        {
            var delete = Table.FirstOrDefault(data => data.Id == id);
            Table.Remove(delete);
            //T model = await Table.FirstOrDefaultAsync(data => data.Id == id);

            //return Remove(model);
        }
      

        public async Task<bool> UpdateAsync(T model)
        {
            EntityEntry entityEntry =  Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
            =>await _context.SaveChangesAsync();

        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}
