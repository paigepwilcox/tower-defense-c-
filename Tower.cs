namespace TowerDefenseGame
{
    class Tower 
    {
        private const int _range = 1;
        private const int _power = 1;
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
            // if (location.OnPath(_location))
            // {
            //     throw new OutOfBoundsException(location + "towers cannot be on the path");
            // }
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }
    }
}