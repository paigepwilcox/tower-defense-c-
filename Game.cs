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
            MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException)
            {

            }
            catch(TowerDefenseException)
            {
                
            }
            catch(Exception ex)
            {
                // throw new System.Exception(ex.Message);
                Console.WriteLine(ex.Message);
            }


            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}