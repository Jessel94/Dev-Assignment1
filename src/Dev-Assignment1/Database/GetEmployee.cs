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
                new Employee(
                    1,
                    "1234",
                    "Henk",
                    "Jan",
                    new List<Adress>
                    {
                        new Adress(
                            1,
                            "Netherlands",
                            "Schiedam",
                            "11a",
                            "3124XJ",
                            "Akkers"),
                        new Adress(
                            2,
                            "England",
                            "London",
                            "321",
                            "postalcode",
                            "londonstreet")
                    },
                    new List<Position>
                    {
                        new Position(
                            1,
                            "Software Engineer")
                    }
                ),
                new Employee(
                    2,
                    "5678",
                    "Jaap",
                    "Worst",
                    null,
                    null
                )
            };
            return employeeList;
        }
    }
}