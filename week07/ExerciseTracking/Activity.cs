public class Activity
{
    private string _date;
    private int _duration; // minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate() => _date;
    public int GetDuration() => _duration;

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_duration} min)";
    }
}
