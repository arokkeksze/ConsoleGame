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

            // Console.WriteLine(Console.WindowWidth);
            // Console.WriteLine(Console.WindowHeight);
            
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

                string thing = "-A";

                switch (thing)
                {
                    case "-A":
                        break;

                    case "--all":
                        Console.WriteLine("goofer moofer");
                        break;

                    default:
                        Console.WriteLine("u stupid");
                        break;
                }

                                    


                // WASD-re ne az O mozogjon, hanemaz ablak
                // O középen fixálva, X is fixált amikor ablak mozog

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

                    case ConsoleKey.End:
                        isInGame = false;
                        break;
                }

                x_x = Math.Max(0, x_x);
                x_x = Math.Min(Console.WindowWidth - 1, x_x);

                x_y = Math.Max(0, x_y);
                x_y = Math.Min(Console.WindowHeight - 1, x_y);

                o_x = Math.Max(0, o_x);
                o_x = Math.Min(Console.WindowWidth - 1, o_x);

                o_y = Math.Max(0, o_y);
                o_y = Math.Min(Console.WindowHeight - 1, o_y);


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