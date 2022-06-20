using MachinistShiftProject.DataAccess.Absract;
using MachinistShiftProject.DataAccess.Concrete;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess
{
    public class ExpeditionReadRepository : ReadRepository<Expedition>, IExpeditionReadRepository
    {
       
        public ExpeditionReadRepository(MachinistShiftDbContext context) : base(context)
        {
        }
    }
}
