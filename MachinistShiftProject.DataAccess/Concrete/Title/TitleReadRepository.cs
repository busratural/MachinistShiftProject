using MachinistShiftProject.DataAccess.Abstract;
using MachinistShiftProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.DataAccess.Concrete
{
    
    public class TitleReadRepository : ReadRepository<Title>, ITitleReadRepository
    {
        public TitleReadRepository(MachinistShiftDbContext context) : base(context)
        {
        }
    }

}
