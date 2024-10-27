public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lenght, double speed): base(date,lenght)
    {
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        return (_speed * GetLenght()) / 60.0;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculatePace()
    {
        return 60/_speed;
    }

     public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLenght()} min) - Virtual Distance {CalculateDistance():0.0} miles, Speed {CalculateSpeed():0.0} mph, Pace: {CalculatePace():0.0} min per mile";
    }
}