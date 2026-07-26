
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace programm_1;
{
    public class Employee
    {
    
        [System.ComponentModel.DataAnnotations.Key]
        public string Ssn { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Minit { get; set; }
        public DateTime Bdate { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public decimal Salary { get; set; }
        public string Super_ssn {get; set;}
        public string Dno { get; set; }
        
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public List<Dependent> Dependents { get; set; } = new();
        public List<workOn> WorkOnprojests { get; set; } = new();
        




    } 
}
