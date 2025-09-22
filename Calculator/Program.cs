using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input;
            double result;
            string calcType = "";

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
                    switch (selection)
                    {
                        case 1:
                        {
                            input = AskNumbers();
                            result = SumOfNumbers(input[0], input[1]);
                            calcType = "Summation";
                            PrintResult(result, calcType, input);
                            break;
                        }

                        case 2:
                        {
                            input = AskNumbers();
                            result = SubtractionOfNumbers(input[0], input[1]);
                            calcType = "Subtraction";
                            PrintResult(result, calcType, input);
                            break;
                        }

                        case 3:
                        {
                            input = AskNumbers();
                            result = DivisionOfNumbers(input[0], input[1]);
                            calcType = "Division";
                            PrintResult(result, calcType, input);
                            break;
                        }

                        case 4:
                        {
                            input = AskNumbers();
                            result = MultiplicationOfNumbers(input[0], input[1]);
                            calcType = "Multiplication";
                            PrintResult(result, calcType, input);
                            break;
                        }
                    }
                    break;
                }
                else
                    Console.WriteLine("Invalid input, try again");
            }
        }

        //Ask user for numbers to do calculus with and return them in array
        static int[] AskNumbers()
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
                    numberA = parsedNumber;

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
                    numberB = parsedNumber;
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

        static void PrintResult(double result, string type, int[] numbers)
        {
            Console.WriteLine(
                $"Type of calculus: {type} \n Numbers to calculate: {numbers[0]}, {numbers[1]} \n {type} of numbers: {result}"
            );
        }
    }
}
