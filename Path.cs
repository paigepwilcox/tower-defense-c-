namespace TowerDefenseGame
{
    class Path 
    {
        private readonly MapLocation[] _path;

        // returns the length of the path array that is encapsalated in the path glass
        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}