using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinistShiftProject.Entities
{
    public class TaskTitle : BaseEntity
    {
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

       
        public  ICollection<TaskDefinition> TaskDefinitions { get; set; }

        public string TaskTitleInformation { get; set; }
       // public TaskDefinition taskDefinition { get; set; }  
      
    }
}
