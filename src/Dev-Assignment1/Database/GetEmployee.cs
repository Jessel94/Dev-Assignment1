using System.Collections.Generic;
using Dev_Assignment1.Models;

namespace Dev_Assignment1.Database
{
    public static class GetEmployee
    {
        public static List<Employee> GetEmployeeList()
        {
            var employeeList = new List<Employee>
            {
                new Employee
                {
                    IdEmployee = 1,
                    Bsn = "1234",
                    Name = "Henk",
                    Surname = "Jan",
                    Adresslist = new List<Adress>
                    {
                        new Adress
                        {
                            Country = "Netherlands",
                            City = "Schiedam",
                            HouseNumber = "11a",
                            PostalCode = "3124XJ",
                            Street = "Akkers"
                        },
                        new Adress
                        {
                            Country = "England",
                            City = "London",
                            HouseNumber = "321",
                            PostalCode = "postalcode",
                            Street = "londonstreet"
                        }
                    }
                },
                new Employee
                {
                    IdEmployee = 2,
                    Bsn = "5678",
                    Name = "Jaap",
                    Surname = "Worst"
                }
            };
            return employeeList;
        }
    }
}