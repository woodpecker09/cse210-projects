public class Running : Activity
{
    private double _distance;
    public Running(string date, int lenght, double distance): base(date,lenght)
    {
        _distance = distance;
    }
   

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
         
        return 60 / CalculatePace();
    }
    public override double CalculatePace()
    {
        int minutes = GetLenght();
        double pace = (double)minutes / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLenght()} min) - Distance {CalculateDistance():0.0} miles, Speed {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.0} min per mile";
    }
}