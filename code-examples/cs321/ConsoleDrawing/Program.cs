public static class ConsoleDrawing
{
    public static char HorizontalLine = '─';
    public static char VerticalLine = '│';
    public static char UpperLeftCorner = '┌';
    public static char UpperRightCorner = '┐';
    public static char LowerRightCorner = '┘';
    public static char LowerLeftCorner = '└';
    public static readonly string FillChars = "ox+#O.X*=%";

    public static void DrawRectangle(int left, int top, int width, int height, char fill)
    {
        for (var j = 0; j < height; j++)
        {
            for (var i = 0; i < width; i++)
            {
                var symbol = fill;
                if (j == 0 || j == height - 1)
                    symbol = HorizontalLine;
                if (i == 0 || i == width - 1)
                    symbol = VerticalLine;
                if (i == 0 && j == 0)
                    symbol = UpperLeftCorner;
                if (i == 0 && j == height - 1)
                    symbol = LowerLeftCorner;
                if (i == width - 1 && j == 0)
                    symbol = UpperRightCorner;
                if (i == width - 1 && j == height - 1)
                    symbol = LowerRightCorner;

                var x = left + i;
                var y = top + j;
                if (x >= Console.BufferWidth || y >= Console.BufferHeight) 
                    continue;
                
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            }
        }
    }


    public static void DrawRandomSquares(int count)
    {
        var random = new Random();
        for (var i = 0; i < count; i++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            var x = random.Next(0, Console.BufferWidth);
            var y = random.Next(0, Console.BufferHeight);
            var width = random.Next(1, Console.BufferWidth / 2);
            var height = random.Next(1, Console.BufferHeight / 2);
            var fillChar = FillChars[random.Next(0, FillChars.Length)];
            DrawRectangle(x, y, width, height, fillChar);
        }
    }

    public static void Main()
    {
        DrawRandomSquares(100);
    }

}

