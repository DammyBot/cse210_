public class Cycling : Activity
{
    private double _speed; // km/h

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min) - Speed: {_speed} km/h";
    }
}
