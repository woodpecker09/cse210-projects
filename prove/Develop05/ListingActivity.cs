public class ListingActivity : Activity
{
    private int _count; 
    private List<string> _prompts;

    public ListingActivity(string name, string descrption) : base(name,descrption)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }
    public void Run()
    {
        DisplayStratingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpiner(5);
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown (5);
        _count = GetListFromUser().Count();
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"{_prompts[index]}");
    }
    public List<string> GetListFromUser()
    {
        List<string> list = new ();
        string inputs = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            inputs = Console.ReadLine();
            if (inputs != "")
            {
                list.Add(inputs);
            }
        }
        return list;
    }
}