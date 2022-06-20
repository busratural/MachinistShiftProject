using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Business.Abstract
{
    public interface IMachinistService 
    {
        public IQueryable<Machinist> GetAll();
        public Task<Machinist> GetById(int id);
        public Task<Machinist> Create(Machinist obj);
        public Task<Machinist> Update(Machinist obj);
        public void Delete(int id);
    }
}
