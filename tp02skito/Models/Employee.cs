using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tp02skito.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }
        public string empName { get; set; }
        public string empPrenom { get; set; }
        public int empAge { get; set; }
    }
}
