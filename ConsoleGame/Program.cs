namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * X, O karakterek
             * X - W-A-S-D karakterekkel mozgatható
             * O - bal-jobb-fel-le karakterekkel mozgatható
             * Ha találkoznak game over
             */

            //kezdő helyek
            int x_x = 10;
            int x_y = 10;

            int o_x = Console.WindowWidth -10;
            int o_y = Console.WindowHeight -10;

            bool isInGame = true;

            while (isInGame)
            {
                Console.Clear();

                // X
                Console.CursorLeft = x_x;
                Console.CursorTop = x_y;
                Console.Write("X");

                // O
                Console.CursorLeft = o_x;
                Console.CursorTop = o_y;
                Console.Write("O");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.LeftArrow:
                        x_x--;
                        break;

                    case ConsoleKey.RightArrow:
                        x_x++;
                        break;

                    case ConsoleKey.UpArrow:
                        x_y--;
                        break;

                    case ConsoleKey.DownArrow:
                        x_y++;
                        break;

                    case ConsoleKey.A:
                        o_x--;
                        break;

                    case ConsoleKey.D:
                        o_x++;
                        break;

                    case ConsoleKey.W:
                        o_y--;
                        break;

                    case ConsoleKey.S:
                        o_y++;
                        break;
                }

                if (x_x == o_x && x_y == o_y)
                {
                    isInGame = false;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                    Console.ReadLine();
                }
            }
        }
    }
}