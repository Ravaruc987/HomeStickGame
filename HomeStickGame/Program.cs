namespace Dice_Game
{
    internal class Program
    {
        public static string? Name { get; set; }
        public static int SumOfPlayer { get; set; }
        public static int SumOfEnemy { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your name:");
            Name = Console.ReadLine();

            int playerRandomNum;
            int enemyRandomNum;

            Random random = new Random();
            while (SumOfEnemy < 65 && SumOfPlayer < 65)
            {
                Console.WriteLine("press any key to roll dice");

                Console.ReadKey();


                playerRandomNum = random.Next(0, 7);
                SumOfPlayer += playerRandomNum;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n{Name} rolled a {playerRandomNum} Sum: {SumOfPlayer}");
                Console.ResetColor();
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(0, 7);
                SumOfEnemy += enemyRandomNum;
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Enemy AI rolled a {enemyRandomNum} Sum: {SumOfEnemy}");
                Console.ResetColor();
            }
            if (SumOfPlayer > SumOfEnemy)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} WIN");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Enemy WIN");
                Console.WriteLine("The END!!!");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
