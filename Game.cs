namespace TowerDefenseGame
{
    class Game
    {
        public static void Main()
        {
            // Instatiation - an instance of a class. creates a new variable tower with the type Tower, assigning tower to a new Tower() object. 
            Tower tower = new Tower();

            Map map = new Map(8, 5);

            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}