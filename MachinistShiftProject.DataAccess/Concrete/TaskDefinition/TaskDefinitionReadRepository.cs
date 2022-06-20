using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.Entities;

namespace MachinistShiftProject.DataAccess.Concrete
{
    public class TaskDefinitionReadRepository : ReadRepository<TaskDefinition>, ITaskDefinitionReadRepository
    {
        public TaskDefinitionReadRepository(MachinistShiftDbContext context) : base(context)
        {
        }
    }
}
