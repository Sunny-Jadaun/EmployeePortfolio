using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EmployeePortfolio.Models
{
    public class emplist {
        [Key]
        [Required]
        [Display(Name = "Employee No:")]
        public int emp_no { get; set; }
    }
    [Table("empportfolio", Schema = "public")]
    public class empInfo
    {
        // public SelectList Dropdownlist { get; set; }
        [Key]
        [Required]
        [Display(Name = "Employee No:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 empno { get; set; }

        
        [Required]
        [Display(Name = "Name of Employee")]
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
        [Display(Name = "Experience In Secure")]
        public int exper { get; set; }

        [Required]
        [Display(Name = "RoadMap for Employee:")]
        public string rmap { get; set; }
    }
}
        

