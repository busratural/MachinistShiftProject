﻿using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Absract
{
    public interface IWriteRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);   
        bool RemoveRange(List<T> datas);
        //  Task<bool> RemoveAsync(int id);
        public void Delete(int İD);
        Task<bool> UpdateAsync(T model);
        Task<int> SaveAsync();
       // void Save();
        


    }
}
