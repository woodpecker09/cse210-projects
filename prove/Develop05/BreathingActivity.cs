public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name,description)
    {
        
        
    }
    public void Run()
    {
        
        DisplayStratingMessage ();
        
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpiner(5);
        
        
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if (i == 0)
            {   
                Console.Write("\nBreath in...");
                ShowCountDown (4);
                i = 1;
            }
            else if (i == 1)
            {
                Console.Write("Breath out...");
                ShowCountDown (6);
                i = 0;
            }
            
        }
        DisplayEndingMessage();
    }
}