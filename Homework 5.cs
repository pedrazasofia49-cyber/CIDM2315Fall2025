namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        int largest = GetLargestNumber();
        Console.WriteLine($"The largest number is: {largest}");
    }

    static int GetLargestNumber()
    {
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        return (num1 > num2) ? num1 : num2;
    
    }
}
