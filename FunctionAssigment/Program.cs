using System.Xml.Linq;

namespace FunctionAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this

            string name = SetUserName();
            int age = SetUserAge();
            PrintUser(age, name);
            bool isAdult = IsAdult(age);

            if (isAdult)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {

                Console.WriteLine("You are not an adult.");
            }
            CompareNames(name, "Matti");

        }

        // Ask for name and ensure it is not empty
        static string SetUserName()
        {
            string name;

            while (true)
            {

                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return name;
        }
        // Ask for age and ensure it is a positive integer

        static int SetUserAge()
        {
            bool valid = false;
            int age = 0;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            return age;
        }
        // Check if the user is an adult

        static bool IsAdult(int age)
        {
            if (age >= 18)
                return true;
            else
                return false;

        }
        // Print name and age
        static void PrintUser(int age, string name)
        {

            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        // Compare the name to another string (e.g., "Matti")
        static void CompareNames(string input, string compareName)
        {



            // Comparison ignoring case
            if (input.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (input.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
    }
}
