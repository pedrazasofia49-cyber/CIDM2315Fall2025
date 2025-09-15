namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.Write("Enter a number: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 2)
        {
            Console.WriteLine($"{N} is non-prime");
            return;
        }
        //Assume N is prime
        bool isPrime = true;

        for (int i = 2; i < N; i++)
        {
            if (N % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine($"{N} is prime");
        else
            Console.WriteLine($"{N} is non-prime");





        // Code for Q2
        Console.Write("Enter an integer N: ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out N);

        if (isValid && N > 0)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer  ");
        }


    // Code for Q3
        Console.Write("Assign an int value to N: ");
         Console.ReadLine();
         int.TryParse(input, out N);

        if (isValid && N > 0)
        {
            for (int row = 1; row <= N; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Move to next line after each row
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }


    }
}
