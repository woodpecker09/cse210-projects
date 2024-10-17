public class ListingActivity : Activity
{
    private int _count; 
    private List<string> _prompts;

    public ListingActivity(string name, string descrption, int duration) : base(name,descrption,duration)
    {
        
        name = "Listing Activity";
        descrption = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
       
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

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        List<string> strings = new();
        _count = strings.Count();
        return strings;
    }
}