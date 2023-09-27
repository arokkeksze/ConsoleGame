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

            while (true)
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

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        x_x--;
                        break;
                }
            }
        }
    }
}