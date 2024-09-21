using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqrNumber = SquareNumber(userNumber);
        DisplayResult(name, sqrNumber);
    }

            
    static void DisplayWelcome ()
        {
            Console.Write("Welcome to the program!");
        }
    static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    static int SquareNumber (int number)
        {
            int sqr = number * number;
            return sqr;
        }
    static void DisplayResult (string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
}