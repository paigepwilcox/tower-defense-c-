// readonly modifier means that the values cannot be changed

namespace TowerDefenseGame
{
    class Map 
    {
        public readonly int Width;
        public readonly int Height;

        // constructor method - never takes void or type
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && 
                    point.Y >= 0 && point.Y < Height;

        }
    }
}