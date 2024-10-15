public class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;
    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeWorkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}