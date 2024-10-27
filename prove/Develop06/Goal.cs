public abstract class Goal
{
    private string _shortName;    
    private string _description;
    private int _points;    
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    
    public abstract bool IsComplete();

    public abstract string GetDetailsString();
    
    public abstract string GetStringRepresentation();
    
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
}