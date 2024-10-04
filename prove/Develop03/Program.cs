using System;

class Program
{
    static void Main(string[] args)
    {
        string end = "";
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
        end = Console.ReadLine(); 
        Reference reference1 = new Reference("hola como estas?, yo bien, y tu?", 2, 2);
        Scripture scripture1 = new Scripture(reference1, reference1.GetDisplayText());
        bool finisher = scripture1.IsCompletelyHidden();
        while(end != "quit" && finisher)
            {
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
                end = Console.ReadLine();
                if (end != "quit" && finisher)
                    {


                        string str = scripture1.GetDisplayText();
                        string[] words = str.Split(' ');
                        int count = words.Count();

                        Random random = new Random();
                        int index = random.Next(count - 1);

                        scripture1.HideRandomWords(index);
                        Console.WriteLine(scripture1.GetDisplayText());
                        finisher = scripture1.IsCompletelyHidden();

                    }
            }
    }
}