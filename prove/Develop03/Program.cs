//(As a stretch challenge, try to randomly select from only those words that are not already hidden.)
//see the class Scripture in the funtion HideRandomWords()
using System;

class Program
{
    static void Main(string[] args)
    {
            Console.Clear();

            Reference newReference = new Reference("Proverbs Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.", 3, 5, 6);
            Scripture newScripture = new Scripture(newReference, newReference.GetDisplayText());
            bool finisher = newScripture.IsCompletelyHidden();

            Console.WriteLine(newScripture.GetDisplayText());
            string end = "";

            while(end != "quit" && !finisher)
                {
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
                    end = Console.ReadLine();
                    if (end != "quit" && !finisher)
                        {

                            Console.Clear();
                            finisher = newScripture.IsCompletelyHidden();
                            if (!finisher)
                                {
                                    newScripture.HideRandomWords(2);
                                    Console.WriteLine(newScripture.GetDisplayText());
                                }


                        }
                }
    }
}