namespace Calculator;
class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine();

            Console.WriteLine("===== Calculator =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Exit");

            Console.Write("Choose an operation: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            if (choice == 0)
            {
                isRunning = false;
                continue;
            }

            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please choose between 0 and 4.");
                continue;
            }

            Console.Write("Enter the first number: ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;

                case 2:
                    result = num1 - num2;
                    break;

                case 3:
                    result = num1 * num2;
                    break;

                case 4:
                    try
                    {
                        if (num2 == 0)
                            throw new DivideByZeroException("Cannot divide by zero.");

                        result = (double)num1 / num2;
                        break;
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}