using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.DataAccess.Concrete;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Business.Concrate
{
    public class MachinistManager : IMachinistService
    {
        private readonly  IMachinistReadRepository _machinistReadRepository;
        private readonly IMachinistWriteRepository _machinistWriteRepository;

        public MachinistManager(IMachinistReadRepository machinistReadRepository, IMachinistWriteRepository machinistWriteRepository)
        {
            _machinistReadRepository = machinistReadRepository;
            _machinistWriteRepository = machinistWriteRepository;
        }
        public MachinistManager(IMachinistReadRepository machinistReadRepository)
        {
            _machinistReadRepository = machinistReadRepository;
        }
        public async Task<Machinist> Create(Machinist obj)
        {
            await _machinistWriteRepository.AddAsync(obj);
            await _machinistWriteRepository.SaveAsync();
             return obj;
        }

        public void Delete(int id)
        {
            _machinistWriteRepository.Delete(id);
            _machinistWriteRepository.SaveAsync();

        }

        public IQueryable<Machinist> GetAll()
        {
            return (IQueryable<Machinist>)_machinistReadRepository.GetAll();
        }

        public async Task<Machinist> GetById(int id)
        {
            return await _machinistReadRepository.GetByIdAsync(id);
        }

        public async Task<Machinist> Update(Machinist obj)
        {
            await _machinistWriteRepository.UpdateAsync(obj);
            await _machinistWriteRepository.SaveAsync();

            return obj;
        }

    }
}
