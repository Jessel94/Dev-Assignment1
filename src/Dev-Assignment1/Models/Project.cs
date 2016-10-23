namespace Dev_Assignment1.Models
{
    public class Project
    {
        public Project(int idProject, string budget, decimal hours)
        {
            IdProject = idProject;
            Budget = budget;
            Hours = hours;
        }

        public int IdProject { get; }

        public string Budget { get; }

        public decimal Hours { get; }
    }
}