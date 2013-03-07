using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eManager.Web.Models
{
    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public int DepartmentId { set; get; }
        
        [Required]
        public string Name { set; get; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { set; get; }
    }
}