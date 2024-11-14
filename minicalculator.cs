using System;

namespace MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.Clear();
                Console.WriteLine("=== Mini Calculator ===");
                Console.WriteLine("Select an operator:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                int choice;
                while (true)
                {
                    Console.Write("Enter your choice (1-5): ");
                    
                    // Try to parse the input as an integer
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                    {
                        // Valid choice within range, exit the loop
                        break;
                    }
                    else
                    {
                        // Invalid choice, prompt again
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    }
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Thank you!");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = GetValidNumber();
                
                Console.Write("Enter the second number: ");
                double num2 = GetValidNumber();

                double result = 0;
                bool validOperation = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"You chose Addition: {num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"You chose Subtraction: {num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"You chose Multiplication: {num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"You chose Division: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.WriteLine("\nPress Enter to return to the menu or type 'no' to exit.");
                continueCalculation = Console.ReadLine()?.ToLower() != "no";
            }
        }

        static double GetValidNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return number;
        }
    }
}
