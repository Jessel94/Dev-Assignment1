namespace Dev_Assignment1.Models
{
    public class Position
    {
        public Position(int idPosition, string positionName)
        {
            IdPosition = idPosition;
            PositionName = positionName;
        }

        public int IdPosition { get; }

        public string PositionName { get; }
    }
}