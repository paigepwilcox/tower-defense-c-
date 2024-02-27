namespace TowerDefenseGame
{
    class Invader 
    {
        // storing an instance of the path object so our Move() function can know and set the location of the invader
        private readonly Path _path;
        private int _pathStep = 0;
        
        // writing properites
        // computed property - a property that does not wrap an actual field
        public MapLocation Location 
        { 
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }

        // constructor makes sure our fields are not null
        public Invader(Path path)
        {
            _path = path;
        }

        // to advance to invader
        public void Move()
        {
            _pathStep += 1;
        }

    }
}

