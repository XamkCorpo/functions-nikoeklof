using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int selection = AskCalculus();
            SelectCalculus(selection);

        }
        //Ask user for the type of calculation, and return the selection as integer
        static int AskCalculus()
        {
            
            Console.WriteLine("Select the type of calculus you would like to do.");
            Console.WriteLine("1) Summation");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Multiplication");

            while (true)
            {
                string calculusSelection = Console.ReadLine();

                if (
                    int.TryParse(calculusSelection, out int selection)
                    && selection > 0
                    && selection <= 4
                )
                {
                    return selection;
                }


                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
        //Selects the operation depending on the selection argument
        static void SelectCalculus(int selection)
        {
            int[] input;
            double result;
            string calcType = "";
            switch (selection)
            {
                case 1:
                    {


                        calcType = "Summation";
                        input = AskNumbers(calcType);
                        result = SumOfNumbers(input[0], input[1]);
                        PrintResult(result, calcType, input);
                        break;
                    }

                case 2:
                    {


                        calcType = "Subtraction";
                        input = AskNumbers(calcType);
                        result = SubtractionOfNumbers(input[0], input[1]);
                        PrintResult(result, calcType, input);
                        break;
                    }

                case 3:
                    {


                        calcType = "Division";
                        input = AskNumbers(calcType);
                        result = DivisionOfNumbers(input[0], input[1]);
                        PrintResult(result, calcType, input);
                        break;
                    }

                case 4:
                    {

                        calcType = "Multiplication";
                        input = AskNumbers(calcType);
                        result = MultiplicationOfNumbers(input[0], input[1]);
                        PrintResult(result, calcType, input);
                        break;
                    }

            }

        }



        //Ask user for numbers to do calculus with and return them in array
        static int[] AskNumbers(string calcType)
        {
            Console.WriteLine("Enter numbers to calculate");

            int numberA;
            int numberB;
            while (true)
            {
                Console.WriteLine("Number a:");
                string firstNumber = Console.ReadLine();
                if (int.TryParse(firstNumber, out int parsedNumber))
                {
                    if (calcType.Equals("Division") && parsedNumber <= 0)
                    {
                        Console.WriteLine("Cannot divide a number that is zero or a negative number, try again");
                        continue;
                    }
                    else numberA = parsedNumber;

                    break;
                }
                else
                {
                    Console.WriteLine("invalid input, try again");
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine("Number b:");
                string firstNumber = Console.ReadLine();
                if (int.TryParse(firstNumber, out int parsedNumber))
                {
                    if (calcType.Equals("Division") && parsedNumber <= 0)
                    {
                        Console.WriteLine("Cannot divide with zero or a negative number, try again");
                        continue;
                    }
                    else numberB = parsedNumber;

                    break;
                }
                else
                {
                    Console.WriteLine("invalid input, try again");
                    continue;
                }
            }
            return [numberA, numberB];
        }
        //function titles explain themselfs
        static int SumOfNumbers(int a, int b)
        {
            return a + b;
        }

        static int SubtractionOfNumbers(int a, int b)
        {
            return a - b;
        }

        static double DivisionOfNumbers(double a, double b)
        {
            return a / b;
        }

        static int MultiplicationOfNumbers(int a, int b)
        {
            return a * b;
        }
        //Print the calculation type, inserted numbers and the result of the calculus
        static void PrintResult(double result, string type, int[] numbers)
        {
            Console.WriteLine(
                $"Type of calculus: {type} \n Numbers to calculate: {numbers[0]}, {numbers[1]} \n {type} of numbers: {result}"
            );
        }
    }
}
