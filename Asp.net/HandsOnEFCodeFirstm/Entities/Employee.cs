using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnEFCodeFirstm.Entities
{
    [Table("Employee")]
    class Employee
    {
        [Key]//set as primary key
        public int Eid { get; set; }
        [Required]//set as not null
        [StringLength(20)]
        public string Ename { get; set; }

        [Column(TypeName ="Date")]
        public DateTime? JoinDate { get; set; }//set as null
        public double? Salary { get; set; }//set as null
       [Column("Designation",TypeName ="Varchar")]
       [StringLength(20)]
       public string Desig { get; set; }
        [StringLength(5)]
        [ForeignKey("Project")]
        public string ProjectCode { get; set; }
        public Project Project { get; set;}//navigation property used to set the relations


    }
}
