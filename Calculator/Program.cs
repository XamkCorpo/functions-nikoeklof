namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select the type of calculus you would like to do.");
            Console.WriteLine("1) Sum");
            Console.WriteLine("2) Difference");
            Console.WriteLine("3) Divide");
            Console.WriteLine("4) Multiply");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int selection) && selection > 0 && selection <= 4)
                {
                    switch (selection)
                    {
                        case 1:
                            {
                                SumOfNumbers();
                                break;
                            }

                        case 2:
                            {
                                SumOfNumbers();
                                break;
                            }

                        case 3:
                            {
                                SumOfNumbers();
                                break;
                            }

                        case 4:
                            {
                                SumOfNumbers();
                                break;
                            }
                    }
                    break;
                }
                else Console.WriteLine("Invalid input, try again");


            }

        }
        static int SumOfNumbers()
        {

            int result = a + b;



            return result;
        }


    }
}
