using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Concrete
{
    public class ExpeditionWriteRepository : WriteRepository<Expedition>, IExpeditionWriteRepository
    {
        public ExpeditionWriteRepository(MachinistShiftDbContext context) : base(context)
        {
        }
    }
}
