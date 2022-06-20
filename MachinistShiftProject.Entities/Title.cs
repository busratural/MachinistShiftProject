using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Entities
{
    public class Title :BaseEntity
    {
       // [Key]
       // public int Id { get; set; }
        public string Title_Name { get; set; }

    }
}
