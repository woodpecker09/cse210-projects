// in line 116 I created a funtion to verifie if the questions are repited or not.
// I enhanced GetRandomQuestion() at line:75 create a while loop to get another random index but the ones that are already used
// I enhanced Run() at line:57 to show a timer for the time remaining of the section
// I enhanced Activity (see Activity for more information)
public class ReflectingActivity : Activity
{
    private List<string> _prompts; 
    private List<string> _questions;

    private List<string> _checkQuestionsList;
    private List<string> _checkPromptsList;
    public ReflectingActivity(string name, string descrption) : base(name,descrption)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",

        };
        _checkQuestionsList = new();
        _checkPromptsList = new();
    }

    public void Run()
    {
        DisplayStratingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpiner(5);
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("you may begain in: ");
        ShowCountDown (5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            if(DateTime.Now < endTime && _checkQuestionsList.Count != _questions.Count)
            {
                DisplayQuestion();   
                ShowSpiner(5);
            }
            else if (_checkQuestionsList.Count == _questions.Count && DateTime.Now < endTime)
            {
                Console.WriteLine("\n\nPonder this questions until the section is done.");
                Console.Write("Remaining time in seconds: ");
                TimeSpan remainingTime = endTime - DateTime.Now;
                int remainingSeconds = (int)remainingTime.TotalSeconds;
                ShowCountDown (remainingSeconds);
                break;
            }    
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        int count1 = 0;
        
        while(CheckList(_prompts[index], _checkPromptsList) && count1 != _prompts.Count)
            {
                index = random.Next(_prompts.Count);
                count1 ++;
            }

        _checkPromptsList.Add(_prompts[index]);
        return _prompts[index]; 
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();

        int index = random.Next(_questions.Count);

        int count1 = 0;
        
        while(CheckList(_questions[index], _checkQuestionsList) && count1 != _questions.Count)
            {
                index = random.Next(_questions.Count);
                count1 ++;
            }

        _checkQuestionsList.Add(_questions[index]);
        return _questions[index]; 
    }
    
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        string enter;
        Console.WriteLine("When you have something in mind, press enter to continue");
        enter = Console.ReadLine();
    }
    public void DisplayQuestion()
    {
        Console.Write($"\n>{GetRandomQuestion()}");
    }


    public bool CheckList(string question, List<string> strings)
    {
        if (strings.Contains(question))
        {
            return true;
        }
        else
        {
            return false;
        }   
    }
}