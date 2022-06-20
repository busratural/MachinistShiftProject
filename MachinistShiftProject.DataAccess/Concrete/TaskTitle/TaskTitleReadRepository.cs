using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Concrete
{
    public class TaskTitleReadRepository : ReadRepository<TaskTitle>, ITaskTitleReadRepository
    {
        public TaskTitleReadRepository(MachinistShiftDbContext context) : base(context)
        {
        }
    }
}
