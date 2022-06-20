using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachinistShiftProject.Business.Abstract;
using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.DataAccess.Concrete;
using MachinistShiftProject.Entities;
namespace MachinistShiftProject.Business.Concrete
{
    public class TaskTitleManager : ITaskTitleService
    {
        private ITaskTitleReadRepository _taskTitleReadRepository;
        private ITaskTitleWriteRepository _taskTitleWriteRepository;

        public TaskTitleManager(ITaskTitleReadRepository taskTitleReadRepository, ITaskTitleWriteRepository taskTitleWriteRepository)
        {
            _taskTitleReadRepository = taskTitleReadRepository;
            _taskTitleWriteRepository = taskTitleWriteRepository;
        }
        public async Task<TaskTitle> Create(TaskTitle obj)
        {
            await _taskTitleWriteRepository.AddAsync(obj);
            await _taskTitleWriteRepository.SaveAsync();

            return obj;
        }

        public void Delete(int id)
        {
            _taskTitleWriteRepository.Delete(id);
            _taskTitleWriteRepository.SaveAsync();

        }

        public IQueryable<TaskTitle> GetAll()
        {
            return (IQueryable<TaskTitle>)_taskTitleReadRepository.GetAll();
        }

        public async Task<TaskTitle> GetById(int id)
        {
            return await _taskTitleReadRepository.GetByIdAsync(id);
        }
        //public TaskTitle GetById(int id)
        //{
        //    _taskTitleReadRepository.GetById(id);
        //}

        public async Task<TaskTitle> Update(TaskTitle obj)
        {
            await _taskTitleWriteRepository.UpdateAsync(obj);
            await _taskTitleWriteRepository.SaveAsync();
            return obj;
        }

       
    }
}
