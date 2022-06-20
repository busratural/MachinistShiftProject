using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Entities
{
    public class TaskDefinition : BaseEntity
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        // public int TaskTitleId { get; set; }

        [ForeignKey("TaskTitleId")]
        public TaskTitle TaskTitle { get; set; }
        // public virtual TaskTitle TaskTitleId { get; set; }
        public string TaskNumber { get; set; }
        public string WorkingHour { get; set; }
        
    }
}
