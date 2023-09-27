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








                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x_x > 0)
                        {
                            x_x--;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (x_x < Console.WindowWidth-1)
                        {
                            x_x++;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (x_y > 1)
                        {
                            x_y--;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (x_y < Console.WindowHeight)
                        {
                            x_y++;
                        }
                        break;

                    case ConsoleKey.A:
                        if (o_x > 0)
                        {
                            o_x--;
                        }
                        break;

                    case ConsoleKey.D:
                        if (o_x < Console.WindowWidth - 1)
                        {
                            o_x++;
                        }
                        break;

                    case ConsoleKey.W:
                        if (o_y > 1)
                        {
                            o_y--;
                        }
                        break;

                    case ConsoleKey.S:
                        if (o_y < Console.WindowHeight)
                        {
                            o_y++;
                        }
                        break;
                    case ConsoleKey.End:
                        isInGame = false;
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