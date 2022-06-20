using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Entities
{
    public class Staff : BaseEntity
    {
        public int SicilNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Title { get; set; } 
        public string Gender { get; set; }
        public string ImagePath { get; set; } 
    }
}
