using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Entities
{
    public class Expedition : BaseEntity
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        public string ExpeditionDirection { get; set; }
        public int TaskNumber { get; set; }
        public int Desk { get; set; }
        public int ExpeditionNumber { get; set; }
        public string DepartureTime { get; set; }  
        public string Headway { get; set; }

    }
}
