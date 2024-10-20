using System;

class Program
{
    static void Main(string[] args)
    {
        int options = 0;

        while(options != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"1. Start Breathing Activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit");
            Console.Write("Select a choice from the menu: ");
            options = int.Parse(Console.ReadLine());
        
            if(options != 4)
            {
                if (options == 1)
                {
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                }
                else if(options == 2)
                {
                    ReflectingActivity breathingActivity = new ReflectingActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    breathingActivity.Run();
                }
                else if(options == 3)
                {
                    ListingActivity breathingActivity = new ListingActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    breathingActivity.Run();
                }
                      
            }
        }
    }
}