using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EmployeePortfolio.Models
{
    [Table("empportfolio,empdata", Schema ="public")]
    public class empInfo
    {
        [ForeignKey("empdata")]
        [Required]
        [Display(Name ="Employee No:")]
        public int empno { get; set; }

        [Required]
        [Display(Name ="Name of Employee")]
        public string empname { get; set; }

        [Required]
        [Display(Name = "Name of Project")]
        public string projname { get; set; }

        [Required]
        [Display(Name = "Select Skills")]
        public string skills { get; set; }

        [Required]
        [Display(Name = "Allocation(%):")]
        public int alloc { get; set; }

        [Required]
        [Display(Name ="Experience In Secure")]
        public DateTime exper { get; set; }

        [Required]
        [Display(Name ="RoadMap for Employee:")]
        public string rmap { get; set; }
    }
}