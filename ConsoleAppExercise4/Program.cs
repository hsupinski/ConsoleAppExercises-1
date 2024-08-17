// 4.Write a program that will calculate the Fibonacci number for an input number. There should
// be 2 input types: reading from console and reading from text file.

using ConsoleAppExercise4;

UserInterface userInterface = new();
FibonacciCalculator fibonacciCalculator = new();

int result = fibonacciCalculator.CalculateFibonacciByIndex(userInterface.PrintMenuAndReturnIndex());

if(result >= 0)
{
    Console.WriteLine($"Fibonacci number is: {result}");
}
else
{
    // invalid input or file reading error
    Console.WriteLine("Invalid input");
}
