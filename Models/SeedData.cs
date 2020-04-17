using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace testaegona.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TestDbContext>>()))
            {
                if (!context.Departments.Any())
                {
                    context.Departments.AddRange(
                    new Department
                    {
                        Id = 1,
                       DepartmentName ="Nhân sự"
                    }
                );
                    context.Departments.AddRange(
                    new Department
                    {
                        Id = 2,
                        DepartmentName = "Software Developer"
                    }

                );
                }
                // Look for any movies.
                if (context.Employees.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employees.AddRange(
                    new Employee
                    {
                        Id = 1,
                        FullName = "Luan",
                        Email = "luan@gmail.com",
                        Phone = "0123",
                        Address = "quang trung",
                        DepartmentId = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}