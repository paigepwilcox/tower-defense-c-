namespace TowerDefenseGame
{
    class Invader 
    {
        // storing an instance of the path object so our Move() function can know and set the location of the invader
        private readonly Path _path;
        private int _pathStep = 0;

        // writing properites
        // computed property - a property that does not wrap an actual field
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        // private set to let coders know to use the method
        public int Health { get; private set; } = 10;
        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        // see if the invader has scored by using the Path and _pathstep fields
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        
        // constructor makes sure our fields are not null
        public Invader(Path path)
        {
            _path = path;
        }

        // to advance to invader
        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor) 
        {
            Health -= factor;
        }

    }
}

