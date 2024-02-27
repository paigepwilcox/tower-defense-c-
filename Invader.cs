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

    }
}