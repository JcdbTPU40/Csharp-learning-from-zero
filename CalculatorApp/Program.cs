using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double memory = 0; // Memory variable to store a value

            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            Console.Write("Enter the second number (if needed): ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            Console.Write("Choose an operation (+, -, *, /, ^ for power, r for square root, m to store to memory, mr to reccall from memory): ");
            char operation = Console.ReadLine()[0];

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                result = num1 + num2;
                break;

                case '-':
                result = num1 - num2;
                break;

                case '*':
                result = num1 * num2;
                break;

                case '/':
                if (num2 != 0)
                result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    validOperation = false;
                }
                break;

                case '^':
                result = Math.Pow(num1, num2); // Power Calculation
                break;

                case 'r':
                if (num1 != 0)
                result = Math.Sqrt(num1); // Square Root
                else
                {
                    Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                    validOperation = false;
                }
                break;

                case 'm': // Store the result in memory
                memory = result;
                Console.WriteLine($"Stored {result} in memory.");
                validOperation = false; // Don't print result as it's just a memory operation
                break;

                case 'mr:' // Recall the memory value
                result = memory;
                Console.WriteLine($"Recalled {memory} from memory.");
                validOperation = false;
                break;

                default:
                Console.WriteLine("Invalid operation chosen.");
                validOperation = false;
                break;
            }

            if(validOperation)
            {
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}