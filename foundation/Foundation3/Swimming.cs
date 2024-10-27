public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int lenght, int numberOfLaps): base(date,lenght)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return (_numberOfLaps * 50)/(1000*0.62);
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / GetLenght()) * 60;
    }
    public override double CalculatePace()
    {
        double distanceInMeters = _numberOfLaps * 50;
        return GetLenght() / (distanceInMeters / 50);
    }

     public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLenght()} min) - Distance {CalculateDistance():0.0}miles, Speed {CalculateSpeed():0.0} mph,Split Time: {CalculatePace():0.0} min per 50 meters";
    }
}