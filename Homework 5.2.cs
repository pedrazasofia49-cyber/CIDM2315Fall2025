namespace Homework5._2;

class Program
{
    static void Main(string[] args)
    {
        int largest = GetLargestOfFour();
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

    
    static int GetLargestOfFour()
    {
        Console.WriteLine("Enter first pair of numbers:");
        int max1 = GetLargestNumber();   

        Console.WriteLine("Enter second pair of numbers:");
        int max2 = GetLargestNumber();   

        Console.WriteLine("Comparing the winners of each pair...");
        int finalMax = (max1 > max2) ? max1 : max2; 

        return finalMax;
    
    }
}
