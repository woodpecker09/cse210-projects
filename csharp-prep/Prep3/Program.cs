using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();

        int magicNumber =  randomNumber.Next(1,101);
        Console.WriteLine($"the magic number is{magicNumber}");
        int guessNumber = 0;
        bool continuePlaying = true;
        int counting = 0;     

        while(magicNumber != guessNumber || continuePlaying)
            {
                
                counting += 1;
                Console.Write("What is the magic number? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                else
                    {
                        Console.WriteLine($"You guessed it! it took {counting} times");
                    }
                if (magicNumber == guessNumber && continuePlaying)
                    {
                        Console.Write("Do you want to keep playing?");
                        string keep = Console.ReadLine();
                        if (keep == "no")
                            {
                                continuePlaying = false;
                            }
                    }
            }
        
    }
}