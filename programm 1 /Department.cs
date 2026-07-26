namespace programm_1;
using System;
using System.Collections.Generic;

public class Department
{
    [System.ComponentModel.DataAnnotations.key]
    public int DepartmentID { get; set; }
    public string DName { get; set; }
    public string Mgr_ssn { get; set; }
    public DateTime Mgr_start_date { get; set; }

    public List<Employee> Employees { get; set; } = new();
    
}