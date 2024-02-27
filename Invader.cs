namespace TowerDefenseGame
{
    class Invader 
    {
        // instatianting a MapLocation class called _location - named this way bc _location is a private field.
        private MapLocation _location;

        //getter
        public MapLocation GetLocation()
        {
            return _location;
        }

        //setter
        public void SetLocation(MapLocation value)
        {
            _location = value;
        }

        // writing properites
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                //value param is implied
                _location = value;
            }
        }

    }
}