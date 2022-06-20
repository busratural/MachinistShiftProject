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
    public class TaskDefinitonManager : ITaskDefinitonService
    {
        private ITaskDefinitionReadRepository _taskDefinitionReadRepository;
        private ITaskDefinitionWriteRepository _taskDefinitionWriteRepository;

        public TaskDefinitonManager(ITaskDefinitionReadRepository taskDefinitionReadRepository, ITaskDefinitionWriteRepository taskDefinitionWriteRepository)
        {
            _taskDefinitionReadRepository = taskDefinitionReadRepository;
            _taskDefinitionWriteRepository = taskDefinitionWriteRepository;
        }
        public async Task<TaskDefinition>  Create(TaskDefinition obj)
        {
           await _taskDefinitionWriteRepository.AddAsync(obj);
            await _taskDefinitionWriteRepository.SaveAsync();

            return obj;
        }

        public void Delete(int id)
        {
            _taskDefinitionWriteRepository.Delete(id);
            _taskDefinitionWriteRepository.SaveAsync();

        }

        public IQueryable<TaskDefinition> GetAll()
        {
            return (IQueryable<TaskDefinition>) _taskDefinitionReadRepository.GetAll();
        }

        public  async Task<TaskDefinition> GetById(int id)
        {
            return await _taskDefinitionReadRepository.GetByIdAsync(id);

        }

        public async Task<TaskDefinition> Update(TaskDefinition obj)
        {
             await _taskDefinitionWriteRepository.UpdateAsync(obj);
            await _taskDefinitionWriteRepository.SaveAsync();
            return obj;
        }
    }
}
