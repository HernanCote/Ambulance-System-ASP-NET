using AmbulanceSystem.Enums;

namespace AmbulanceSystem.Entities
{
    public class Direction
    {
        public int Id { get; set; }
        public int Street { get; set; }
        public int Avenue { get; set; }
        public int Number { get; set; }
        public DirectionType Type { get; set; }
    }
}