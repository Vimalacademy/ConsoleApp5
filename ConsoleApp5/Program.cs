using System;

// Create a class named MathOperations
public class MathOperations
{
    // Create a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer (let's say we add 10 to it)
        int result = firstNumber + 10;

        // Display the second integer to the screen
        Console.WriteLine($"Second Number: {secondNumber}");

        // Display the result of the math operation
        Console.WriteLine($"Result of Operation: {result}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations math = new MathOperations();

        // Call the PerformOperation method in the class, passing in two numbers
        math.PerformOperation(5, 20);

        // Call the PerformOperation method in the class, specifying the parameters by name
        math.PerformOperation(firstNumber: 8, secondNumber: 15);
    }
}
