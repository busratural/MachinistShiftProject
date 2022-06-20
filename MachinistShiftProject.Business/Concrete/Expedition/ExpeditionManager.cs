using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.Business.Concrete;
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
    public class ExpeditionManager : IExpeditionService

    {
        private IExpeditionReadRepository _expeditionReadRepository;
        private IExpeditionWriteRepository _expeditionWriteRepository;

        public  ExpeditionManager(IExpeditionReadRepository expeditionReadRepository, IExpeditionWriteRepository expeditionWriteRepository)
        {
            _expeditionReadRepository = expeditionReadRepository;
            _expeditionWriteRepository = expeditionWriteRepository;
        }

        public async Task<Expedition>  Create(Expedition obj)
        {
            await _expeditionWriteRepository.AddAsync(obj);
            await _expeditionWriteRepository.SaveAsync();

            return obj;
        }

        public void Delete(int id)
        {
            _expeditionWriteRepository.Delete(id);
            _expeditionWriteRepository.SaveAsync();

        }

        public IQueryable<Expedition> GetAll()
        {
           return (IQueryable<Expedition>)_expeditionReadRepository.GetAll();

        }

        public async Task<Expedition> GetById(int id)
        {
            return await _expeditionReadRepository.GetByIdAsync(id);
            
        }

        public async Task<Expedition> Update(Expedition obj)
        {
           await _expeditionWriteRepository.UpdateAsync(obj);
            await _expeditionWriteRepository.SaveAsync();
            return   obj;
        }
    }

}

