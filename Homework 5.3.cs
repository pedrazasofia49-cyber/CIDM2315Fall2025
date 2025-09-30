namespace Homework5._3;

class Program
{
    static void Main(string[] args)
    {
         createAccount();
    }

    
    static bool checkAge(int birth_year)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birth_year;

        if (age >= 18)
            return true;
        else
            return false;
    }

    
    static void createAccount()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password1 = Console.ReadLine();

        Console.Write("Re-enter password: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    
    }
}
