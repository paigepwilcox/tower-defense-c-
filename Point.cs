
namespace TowerDefenseGame
{
    class Point 
    {
        public readonly int X; 
        public readonly int Y;
        

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceBetween(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) * Math.Pow(Y-y, 2) );
        }

        public int DistanceBetween(Point point)
        {
            return DistanceBetween(point.X, point.Y);
        }
    } 
}