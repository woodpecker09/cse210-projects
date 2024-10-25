public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base (shortName, description, points)
    {

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}