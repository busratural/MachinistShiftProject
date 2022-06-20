using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachinistShiftProject.Entities
{
    public class Machinist : BaseEntity
    {
       //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // public int Id { get; set; }
       
        public int RegistrationNumber { get; set; }     
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Title { get; set; }
        [StringLength(50)]
        public string Gender { get; set; }
        [StringLength(50)]
        public string ImagePath { get; set; }


    }
}