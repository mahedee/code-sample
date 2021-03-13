using System;
using System.Linq;
using HRM.Db;
using HRM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class SeedDataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new HRMContext(
            serviceProvider.GetRequiredService<DbContextOptions<HRMContext>>()))
        {
            // Check any employee exists 
            if (context.Employees.Any())
            {
                return; // Data already exists no need to generate
            }

            context.Employees.AddRange(
                new Employee
                {
                    Name = "Md. Mahedee Hasan",
                    Designation = "Head of Software Development",
                    FathersName = "Yeasin Bhuiyan",
                    MothersName = "Moriom Begum",
                    DateOfBirth = new DateTime(1984, 12, 19, 00, 00, 00)
                },

                new Employee
                {
                    Name = "Khaleda Islam",
                    Designation = "Software Engineer",
                    FathersName = "Shahidul Islam",
                    MothersName = "Momtaz Begum",
                    DateOfBirth = new DateTime(1990, 10, 29, 00, 00, 00)
                },

                new Employee
                {
                    Name = "Tahiya Hasan Arisha",
                    Designation = "Jr. Software Engineer",
                    FathersName = "Md. Mahedee Hasan",
                    MothersName = "Khaleda Islam",
                    DateOfBirth = new DateTime(2017, 09, 17, 00, 00, 00)
                }
            );
            context.SaveChanges();

        }
    }
}