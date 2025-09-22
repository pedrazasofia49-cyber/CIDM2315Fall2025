namespace Homework4;

class Program
{
    
 //Q1 Code
    static int GetLargest(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second nunmber: ");
        int number2 = int.Parse(Console.ReadLine());

        int largest = GetLargest(number1, number2);

        Console.WriteLine("The largest number is: " + largest);
    }
}
