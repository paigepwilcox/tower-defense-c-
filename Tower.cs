using System.Runtime.InteropServices;

namespace TowerDefenseGame
{
    class Tower 
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
            // if (location.OnPath(_location))
            // {
            //     throw new OutOfBoundsException(location + "towers cannot be on the path");
            // }
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                Console.WriteLine("made it into the foreach loop");
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    Console.WriteLine("passed first condition");
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("shots fired!");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("enemy neutralized!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("shots missed!");
                    }
                    break;
                }
            }
        }
    }
}