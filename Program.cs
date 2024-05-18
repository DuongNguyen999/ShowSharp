internal class Program
{
    private static void Main(string[] args)
    {
     
        int choice;
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle (bottom-left)");
            Console.WriteLine("3. Print the square triangle (top-left)");
            Console.WriteLine("4. Print the square triangle (bottom-right)");
            Console.WriteLine("5. Print the square triangle (top-right)");
            Console.WriteLine("6. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle(3, 7); // Adjust the dimensions as needed
                    break;
                case 2:
                    PrintSquareTriangleBottomLeft(5);
                    break;
                case 3:
                    PrintSquareTriangleTopLeft(5);
                    break;
                case 4:
                    PrintSquareTriangleBottomRight(5);
                    break;
                case 5:
                    PrintSquareTriangleTopRight(5);
                    break;
                case 6:
                    PrintIsoscelesTriangle(5);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        }
    }

    static void PrintRectangle(int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleBottomLeft(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleTopLeft(int size)
    {
        for (int i = size; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleBottomRight(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            for (int j = size; j > i; j--)
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSquareTriangleTopRight(int size)
    {
        for (int i = size; i >= 1; i--)
        {
            for (int j = size; j > i; j--)
            {
                Console.Write("  ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintIsoscelesTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = height; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}