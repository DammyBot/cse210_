public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min) - Laps: {_laps}";
    }
}
