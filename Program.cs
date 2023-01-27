using System;

/*
 * Class: Program
 * 
 * Author: Yanzhi Wang
 * 
 * Purpose: This class contains the main method of the console application. It prompts the user to enter two numbers and checks if both numbers are greater than 10. If both numbers are greater than 10, the user will be prompted to enter new numbers. Once valid numbers are entered, the program displays the numbers entered by the user.
 * 
 * Restrictions: The program only accepts integer input. It does not handle invalid input or exceptions.
 */
class Program
{
    /*
     * Method: Main
     * 
     * Purpose: This method is the entry point of the console application. It prompts the user to enter two numbers, checks if both numbers are greater than 10, and displays the numbers entered by the user if they are valid.
     * 
     * Restrictions: The program only accepts integer input. It does not handle invalid input or exceptions.
     * 
     * Parameters:
     *  - string[] args: command-line arguments passed to the program
     * 
     * Returns: None
     */
    static void Main(string[] args)
    {
        int var1, var2; // Declaring variables to store the user input
        do
        {
            Console.WriteLine("Enter first number:");
            var1 = int.Parse(Console.ReadLine()); // Prompting user to enter the first number and storing it in var1
            Console.WriteLine("Enter second number:");
            var2 = int.Parse(Console.ReadLine()); // Prompting user to enter the second number and storing it in var2
            if ((var1 > 10) && (var2 > 10)) // Checking if both numbers are greater than 10
            {
                Console.WriteLine("Both numbers cannot be greater than 10. Please enter new numbers.");
            }
        } while ((var1 > 10) && (var2 > 10)); // Repeat the process until both numbers are not greater than 10
        Console.WriteLine("You entered: " + var1 + " and " + var2); // Displaying the numbers entered by the user
    }
}
