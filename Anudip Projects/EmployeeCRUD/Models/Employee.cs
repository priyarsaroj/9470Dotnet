using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
            [Key]
            public int Id { get; set; }
            [Required]
            [Display(Name = "Employee Name")]
            public string Name { get; set; }
            public string Designation { get; set; }
            [DataType(DataType.MultilineText)]
            public string Address { get; set; }
            public DateTime? RecordCreatedOn { get; set; }

        }
    }
