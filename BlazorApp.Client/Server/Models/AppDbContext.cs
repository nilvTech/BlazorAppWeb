using BlazorApp.Client.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Client.Server.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@DropBox.com",
                Phone = "+1 202-918-2132",
                Address = "221b Baker Street,albuquerque,USA ",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@DropBox.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Phone = "+1 578-456-695",
                Address = "2218 Kurtis Street, Suite 828, 95726, New Abel, Alaska,USA",
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/sam.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@DropBox.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Phone = "+1 578-512-635",
                Address = "5461 Zelma Light, Suite 786, 51132, North Gavin, Connecticut, USA",
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/mary.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@DropBox.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Phone = "+1 534-126-667",
                Address = "076 Grayce Squares, Apt. 090, 78353, Gulgowskiside, Tennessee,USA ",
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sara.png"
            });
        }
    }
}
