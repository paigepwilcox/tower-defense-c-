namespace TowerDefenseGame
{
    // MapLocation is a subclass of the Point class, defined by the colon.
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + y + "outside of the boundaries");
            }
        }
    }
}