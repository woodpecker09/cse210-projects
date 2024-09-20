using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string gradeLetter = "";
        bool passGrade = true;
        string sings = "";
        if (grade >= 90)
            {
                gradeLetter = "A";
            }
        else if (grade >= 80)
            {
                gradeLetter = "B";
            }
        else if (grade >= 70)
            {   
                gradeLetter = "C";
            }
        else if (grade >= 60)
            {
                gradeLetter = "D";
                passGrade = false;
            }
        else if (grade < 60)
            {
                gradeLetter = "F";
                passGrade = false;
            }
        if (!(grade >= 94 || grade < 60))
            {
                if(grade % 10 >= 7)
                    {
                        sings = "+";
                    }
                else if (grade % 10 <= 3 )
                    {
                        sings = "-";
                    }
            }
        if (passGrade)
            {
                Console.WriteLine($"Congratulations, you pass the class with a {gradeLetter}{sings}");
            }
        else
            {
                Console.WriteLine($"Sorry, you didn't pass the class, your grade is {gradeLetter}{sings}");
            }
        
    }
}