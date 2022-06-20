using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.DataAccess.Abstract;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Business.Concrete
{
    public class TitleManager : ITitleService
    {
        private readonly ITitleReadRepository _titleReadRepository;
        private readonly ITitleWriteRepository _titleWriteRepository;

        public TitleManager(ITitleReadRepository titleReadRepository, ITitleWriteRepository titleWriteRepository)
        {
            _titleReadRepository = titleReadRepository;
            _titleWriteRepository = titleWriteRepository;
        }
        public async Task<Title> Create(Title obj)
        {
            await _titleWriteRepository.AddAsync(obj);
            await _titleWriteRepository.SaveAsync();
            return obj;
        }

        public void Delete(int id)
        {
            _titleWriteRepository.Delete(id);
            _titleWriteRepository.SaveAsync();

        }

        public IQueryable<Title> GetAll()
        {
            return (IQueryable<Title>)_titleReadRepository.GetAll();
        }

        public async Task<Title> GetById(int id)
        {
            return await _titleReadRepository.GetByIdAsync(id);
        }

        public async Task<Title> Update(Title obj)
        {
            await _titleWriteRepository.UpdateAsync(obj);
            await _titleWriteRepository.SaveAsync();

            return obj;
        }
    }
}
