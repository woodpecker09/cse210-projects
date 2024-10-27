using System.Diagnostics.Contracts;

public abstract class Activity
{
    private string _date;
    
    private int _lenght;//<---- minutes

    public Activity(string date, int lenght)
    {
        _date = date;
        _lenght = lenght;
    }
    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public abstract string GetSummary();

    public string GetDate()
    {
        return _date;
    }

    public int GetLenght()
    {
        return _lenght;
    }
}