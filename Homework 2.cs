using System.Reflection.Metadata;

namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // code for Q1
        
        Console.WriteLine("Enter a letter grade: ");
        string grade = Console.ReadLine().ToUpper();

        int gpa;

        switch (grade)
        {
            case "A":
                gpa = 4;
                break;
            case "B":
                gpa = 3;
                break;
            case "C":
                gpa = 2;
                break;
            case "D":
                gpa = 1;
                break;
            case "F":
                gpa = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine("GPA Point: " + gpa);


        // Code for Q2
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest;

        if (num1 <= num2)
        {
            if (num1 <= num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 <= num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }

        Console.WriteLine("Smallest value: " + smallest);

        // Code for Q3
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeap = false;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeap = true;
                }
                else
                {
                    isLeap = false;
                }
            }
            else
            {
                isLeap = true;
            }
        }
        else
        {
            isLeap = false;
        }

        if (isLeap)
            Console.WriteLine($"{year} is a leap year");
        else
            Console.WriteLine($"{year} is not a leap year");
        
    }
}
