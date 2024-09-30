using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");


        int numberInput = 0;
        Journal s = new Journal();
        
        while (numberInput != 5)
            {
                Console.WriteLine("What would you like to do? \n1 Write \n2 Display \n3 Load \n4 Save \n5 Quit");
                numberInput = int.Parse(Console.ReadLine());
                if (numberInput != 5)
                    {
                        if(numberInput == 1)
                            {
                                
                                Entry exclusivo = new Entry();
                                s.AddEntry(exclusivo); 
        
                            }
                        else if(numberInput == 2)
                            {
                                s.DisplayAll();
                            } 
                        else if(numberInput == 3)
                            {
                                Console.WriteLine("What is the file name that you want to read? ");
                                string fileName = Console.ReadLine();
                                s.LoadFromFile(fileName);
                            } 
                        else if(numberInput == 4)
                            {
                                Console.WriteLine("What is the file name? ");
                                string fileName = Console.ReadLine();
                                s.SaveToFile(fileName);
                            } 
                    }
            }
    }
}