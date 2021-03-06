using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
