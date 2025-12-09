public class Running : Activity
{
    private double _distance; // km

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) - Distance: {_distance} km";
    }
}
