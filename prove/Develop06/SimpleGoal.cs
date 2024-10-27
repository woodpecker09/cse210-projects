public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) : base (shortName, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        if(_isComplete)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        
        
            return $"{GetShortName()} ({GetDescription()})";
        
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~{GetShortName()}~{GetDescription()}~{GetPoints()}~{_isComplete}";
    }
}