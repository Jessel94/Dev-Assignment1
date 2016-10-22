using System.Collections.Generic;

namespace Dev_Assignment1.Models
{
    public class Employee
    {
        public Employee(int idEmployee, string bsn, string name, string surname, List<Adress> adresslist, List<Position> positionList)
        {
            IdEmployee = idEmployee;
            Bsn = bsn;
            Name = name;
            Surname = surname;
            Adresslist = adresslist;
            PositionList = positionList;
        }

        public int IdEmployee { get; }

        public string Bsn { get; }

        public string Name { get; }

        public string Surname { get; }

        public List<Adress> Adresslist { get; }

        public List<Position> PositionList { get; }
    }
}