namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Mario Cart", "Jenga", "Pac-Man"};
            var gameNames = games.OrderByDescending(x => x.Length).ToList();
            foreach (var gameName in gameNames)
            {
                Console.WriteLine(gameName);
            }

        }
    }
}
