namespace Dev_Assignment1.Models
{
    public class Position
    {
        public Position(int idPosition, string positionName, string description, string hourFee, int idProject)
        {
            IdPosition = idPosition;
            PositionName = positionName;
            Description = description;
            HourFee = hourFee;
            IdProject = idProject;
        }

        public int IdPosition { get; }

        public string PositionName { get; }

        public string Description { get; }

        public string HourFee { get; }

        public int IdProject { get; }
    }
}