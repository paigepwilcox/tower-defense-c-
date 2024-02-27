namespace TowerDefenseGame
{
    class Tower 
    {
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
            for(int i = 0; i < invaders.Length; i++)
            {
                Invader invader = invaders[i]
            }
        }
    }
}