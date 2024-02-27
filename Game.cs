namespace TowerDefenseGame
{
    class Game
    {
        public static void Main()
        {
            // Instatiation - an instance of a class. creates a new variable tower with the type Tower, assigning tower to a new Tower() object. 
            /// Tower tower = new Tower();

            Map map = new Map(8, 5);
            try
            {
                Path path = new Path(
                    new [] {
                        // passing in map to verify points
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                    }
                );

                Invader[] invaders = 
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };


                Tower[] towers = 
                {
                    new Tower(new MapLocation(1,3, map)),
                    new Tower(new MapLocation(3,3, map)),
                    new Tower(new MapLocation(5,3, map)),
                };

                Level level = new Level(invaders)
                {
                    // we can only do this with properties, notice there is no semicolon, set on construction
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("player " + (playerWon? "Wone!": "lost"));

                MapLocation location = new MapLocation(0,0, map);

                // using property
                // invader.Location = location;
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TowerDefenseException ex)
            {
                Console.WriteLine("Unhandled towerdefense exception ", ex.Message);
            }
            catch(Exception ex)
            {
                // throw new System.Exception(ex.Message);
                Console.WriteLine("Unhandled Exception: ", ex.Message);
            }


            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}