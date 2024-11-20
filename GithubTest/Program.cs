class Program
{
    static void Main(string[] args)
    {

        int x = 5;
        int y = 10;
        int maxX = Console.WindowWidth - 2;
        int maxY = Console.WindowHeight - 2;
        int dirX = 1;
        int dirY = 1;
        Console.CursorVisible = false;
        Console.Clear();
        while (true)
        {
            int oldX = x;
            int oldY = y;
            x += dirX;
            y += dirY;
            Console.SetCursorPosition(x, y);
            Console.Write("O");
            Console.SetCursorPosition(oldX, oldY);
            Console.Write(" ");
            System.Threading.Thread.Sleep(50);

            if (x < 1) dirX = 1;
            if (x > maxX) dirX = -1;
            if (y < 1) dirY = 1;
            if (y > maxY) dirY = -1;
        }
    }
}
