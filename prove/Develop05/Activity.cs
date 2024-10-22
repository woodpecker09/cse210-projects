/* I enhanced ShowCountDown() at line:58 using another for loop to ensure that the numbers in the console
are erased does not matter how many numbers are Units,Tens,Hundreds,etc.*/
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public  Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStratingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.Write("\nhow long in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpiner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        ShowSpiner(5);
    }
    public void ShowSpiner(int seconds)
    {
        List<string> animationString = new List<string>
        {
            "|","/","-","\\","|","/","-","\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            
            Thread.Sleep(250);

            Console.Write("\b \b");

            i++;
            
            if(i >= animationString.Count())
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown (int seconds)
    {
        for (int i = 1; seconds >= i; seconds--)
        {
            Console.Write(seconds);
 
            string currentDisplay = seconds.ToString();

            Thread.Sleep(1000);

            for (int j = 0; j < currentDisplay.Length; j++)
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("");    
    }
    
    public int GetDuration()
    {
        return _duration;
    }
}