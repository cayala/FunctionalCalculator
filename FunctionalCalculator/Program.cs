using FunctionalCalculator.Operators;
using System;

namespace FunctionalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is a fully functional calculator with simple operations");
            Console.WriteLine("Please input your left argument");

            int leftArg = GetNumInput(Console.ReadKey());
            ConsoleNewLine();

            Console.WriteLine("Please input your operator");
            
            var operation = Console.ReadKey();
            ConsoleNewLine();

            Console.WriteLine("Please input your right argument");
            var rightArg = GetNumInput(Console.ReadKey());
            ConsoleNewLine();

            ConsoleEvaluateOperation(GetOperator(operation, leftArg, rightArg));
            ExitProgram();

            static int GetNumInput(ConsoleKeyInfo input)
                => input.Key switch
                {
                    ConsoleKey.D1 => 1,
                    ConsoleKey.NumPad1 => 1,
                    ConsoleKey.D2 => 2,
                    ConsoleKey.NumPad2 => 2,                    
                    ConsoleKey.D3 => 3,
                    ConsoleKey.NumPad3 => 3,                    
                    ConsoleKey.D4 => 4,
                    ConsoleKey.NumPad4 => 4,                    
                    ConsoleKey.D5 => 5,
                    ConsoleKey.NumPad5 => 5,                    
                    ConsoleKey.D6 => 6,
                    ConsoleKey.NumPad6 => 6,
                    ConsoleKey.D7 => 7,
                    ConsoleKey.NumPad7 => 7,
                    ConsoleKey.D8 => 8,
                    ConsoleKey.NumPad8 => 8,
                    ConsoleKey.D9 => 9,
                    ConsoleKey.NumPad9 => 9,
                    _ => throw new ArgumentException("Key entered is not valid")
                };
            static IOperator GetOperator(ConsoleKeyInfo input, int leftArg, int rightArg)
                => input.Key switch
                {
                    ConsoleKey.Add => new Add(leftArg, rightArg),
                    ConsoleKey.Subtract => new Subtract(leftArg, rightArg),
                    ConsoleKey.Multiply => new Multiply(leftArg, rightArg),
                    ConsoleKey.Divide => new Divide(leftArg, rightArg),
                    _ => throw new ArgumentException("This is not a valid operator")
                };
            void ConsoleNewLine()
                => Console.WriteLine(Environment.NewLine);
            static void ConsoleEvaluateOperation(IOperator op)
                => Console.WriteLine($"The value of the operation is {op.Evaluate()}");
            void ExitProgram() 
            {
                Console.WriteLine("Press any key to end the program");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
