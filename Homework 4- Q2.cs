namespace Homework4._2;

class Program
{
    // Q2 Code
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N = {N}");
        Console.WriteLine($"Shape = {shape}");

        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                string spaces = new string(' ', N - i);
                string stars = new string('*', i);
                Console.WriteLine(spaces + stars);
            }
        }
        else
        {
            Console.WriteLine("Invalid shape. Use 'left' or 'right'.");
        }
    }

    static void Main(string[] args)
    {

        Console.Write("Enter the number of rows (N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the shape (left/right): ");
        string shape = Console.ReadLine();


        PrintTriangle(N, shape);
    }

    
}
