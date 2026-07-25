using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace programm_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var db = new CompanyContext();
            db.Database.EnsureCreated();
            Console.WriteLine("Company database and tables created successfully!");
        }
    }

    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DeptLocation> DeptLocations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorksOn> WorksOn { get; set; }
        public DbSet<Dependent> Dependents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1434;Database=CompanyDB;User Id=sa;Password=YourStrong@Password1;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeptLocation>().HasKey(d => new { d.Dnumber, d.Dlocation });
            modelBuilder.Entity<WorksOn>().HasKey(w => new { w.Essn, w.Pno });
            modelBuilder.Entity<Dependent>().HasKey(d => new { d.Essn, d.Dependent_name });
        }
    }

    public class Employee
    {
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public string Ssn { get; set; }
        public DateTime Bdate { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public decimal Salary { get; set; }
        public string Super_ssn { get; set; }
        public int Dno { get; set; }
    }

    public class Department
    {
        public string Dname { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public int Dnumber { get; set; }
        public string Mgr_ssn { get; set; }
        public DateTime Mgr_start_date { get; set; }
    }

    public class DeptLocation
    {
        public int Dnumber { get; set; }
        public string Dlocation { get; set; }
    }

    public class Project
    {
        public string Pname { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public int Pnumber { get; set; }
        public string Plocation { get; set; }
        public int Dnum { get; set; }
    }

    public class WorksOn
    {
        public string Essn { get; set; }
        public int Pno { get; set; }
        public decimal Hours { get; set; }
    }

    public class Dependent
    {
        public string Essn { get; set; }
        public string Dependent_name { get; set; }
        public string Sex { get; set; }
        public DateTime Bdate { get; set; }
        public string Relationship { get; set; }
    }
}