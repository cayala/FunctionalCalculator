using FunctionalCalculator;
using FunctionalCalculator.Operators;
using System;

class Solution
{
    private const string NotANumberErrorMsg = "Error, what was entered was not a number";
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");

        if (!int.TryParse(Console.ReadLine(), out int leftSide))
            DisplayNotANumberError();

        Console.WriteLine("Please enter an operator");
        string userOperator = Console.ReadLine();

        Console.WriteLine("Please enter a second number");

        if (!int.TryParse(Console.ReadLine(), out int rightSide))
            DisplayNotANumberError();

        Console.WriteLine($"The result of the operation is: {GetOperationResult(userOperator, leftSide, rightSide)}");
        ExitProgram();

        static int GetOperationResult(string userOperator, int leftSide, int rightSide) 
            => userOperator switch
            {
                "+" => new Add(leftSide, rightSide).Evaluate(),
                "-" => new Subtract(leftSide, rightSide).Evaluate(),
                "*" => new Multiply(leftSide, rightSide).Evaluate(),
                "/" => new Divide(leftSide, rightSide).Evaluate(),
                _ => throw new ArgumentException("Operator not found")
            };
        static void DisplayNotANumberError()
        {
            Console.WriteLine(NotANumberErrorMsg);
            ExitProgram();
        }
        static void ExitProgram()
        {
            Console.WriteLine("Press any key to end the program");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

