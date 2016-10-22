namespace Dev_Assignment1.Models
{
    public class Degree
    {
        public Degree(int idDegree, string course, string school, string level)
        {
            IdDegree = idDegree;
            Course = course;
            School = school;
            Level = level;
        }

        public int IdDegree { get; }

        public string Course { get; }

        public string School { get; }

        public string Level { get; }
    }
}