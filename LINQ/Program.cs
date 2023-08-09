namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() 
            { "Mario Cart", 
              "Jenga", 
              "Pac-Man"};
            var gameNames = games.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine("Here is a list of game names in descending order by length of each name:\n");
            foreach (var gameName in gameNames)
            {
                Console.WriteLine(gameName);
            }

        }
    }
}
