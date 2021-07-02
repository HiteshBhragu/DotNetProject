using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Crud.Models
{
    public class Project
    {
        [Key]
        public int? ProjectId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
     
        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Start Date")]
        public string StartDate { get; set; }
        
    }
}
