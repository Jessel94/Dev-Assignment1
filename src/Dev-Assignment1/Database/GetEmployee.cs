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
                            "Software Engineer",
                            "engineers all the softwares",
                            "$12,50",
                            1
                        ),
                        new Position(
                            2,
                            "Project lead",
                            "Leads a team",
                            "$22,50",
                            2
                        )
                    },
                    new List<Degree>()
                    {
                        new Degree(
                            1,
                            "Software engineering",
                            "Hogeschool Rotterdam",
                            "Masters"),
                        new Degree(
                            1,
                            "Software engineering",
                            "Hogeschool Rotterdam",
                            "Masters")
                    }
                ),
                new Employee(
                    2,
                    "5678",
                    "Jaap",
                    "Worst",
                    null,
                    null,
                    null
                )
            };
            return employeeList;
        }

        public static Employee GetEmployeeInfo(int id)
        {
            return new Employee(
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
                        "Software Engineer",
                        "engineers all the softwares",
                        "$12,50",
                        1
                    ),
                    new Position(
                        2,
                        "Project lead",
                        "Leads a team",
                        "$22,50",
                        2
                    )
                },
                new List<Degree>()
                {
                    new Degree(
                        1,
                        "Software engineering",
                        "Hogeschool Rotterdam",
                        "Masters"),
                    new Degree(
                        1,
                        "Software engineering",
                        "Hogeschool Rotterdam",
                        "Masters")
                });
        }
    }
}