namespace TowerDefenseGame
{
    class Invader 
    {
        // storing an instance of the path object so our Move() function can know and set the location of the invader
        private readonly Path _path;
        private int _pathStep = 0;
        // writing properites
        public MapLocation Location { get; private set; }

        // constructor makes sure our fields are not null
        public Invader(Path path)
        {
            _path = path;
            Location = path.GetLocationAt(0);
        }

        // to advance to invader
        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
            
        }

    }
}