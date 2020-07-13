using PracticePizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePizzaPlace.Data
{
    public class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee {FirstName = "Barbra", LastName = "QueChicken", PhoneNumber = "123-123-1234", Role = Roles.Manager, Salary = 100000M},
                new Employee {FirstName = "Gary", LastName = "Pepperoni", PhoneNumber = "123-123-1234", Role = Roles.AssistantManager, Salary = 75000M},
                new Employee {FirstName = "Shiitake", LastName = "Mushrooms", PhoneNumber = "123-123-1234", Role = Roles.Cashier, Salary = 40000M},
                new Employee {FirstName = "Tony", LastName = "Marinara", PhoneNumber = "123-123-1234", Role = Roles.Insider, Salary = 40000M},
                new Employee {FirstName = "Italiano", LastName = "Sausage", PhoneNumber = "123-123-1234", Role = Roles.Driver, Salary = 40000M},
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();

        }
    }
}
