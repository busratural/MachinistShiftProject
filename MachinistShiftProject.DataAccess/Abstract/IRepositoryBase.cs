using MachinistShiftProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Absract
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
       public DbSet<T> Table { get; }
        //IQueryable<T> GetAll();
        //Task<T>  GetById(object id);
        //T Insert(T obj);
        //T  Update(T obj);
        //void Delete(object id);
        //void Save();
    }
   
}
