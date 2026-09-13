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

            int choice = int.Parse(Console.ReadLine());

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
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

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
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}