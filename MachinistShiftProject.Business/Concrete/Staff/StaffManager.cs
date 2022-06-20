using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.DataAccess.Abstract;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffShiftProject.Business.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffReadRepository _staffReadRepository;
        private readonly IStaffWriteRepository _staffWriteRepository;
        public StaffManager(IStaffReadRepository staffReadRepository, IStaffWriteRepository staffWriteRepository)
        {
            _staffReadRepository = staffReadRepository;
            _staffWriteRepository = staffWriteRepository;
        }
        public async Task<Staff> Create(Staff obj)
        {
            await _staffWriteRepository.AddAsync(obj);
            await _staffWriteRepository.SaveAsync();
            return obj;
        }

        public void Delete(int id)
        {
            _staffWriteRepository.Delete(id);
            _staffWriteRepository.SaveAsync();

        }

        public IQueryable<Staff> GetAll()
        {
            return (IQueryable<Staff>)_staffReadRepository.GetAll();
        }

        public async Task<Staff> GetById(int id)
        {
            return await _staffReadRepository.GetByIdAsync(id);
        }

        public async Task<Staff> Update(Staff obj)
        {
            await _staffWriteRepository.UpdateAsync(obj);
            await _staffWriteRepository.SaveAsync();

            return obj;
        }
    }
}
