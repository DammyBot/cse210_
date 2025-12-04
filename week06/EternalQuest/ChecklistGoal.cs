public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (IsComplete())
        {
            Console.WriteLine($"You completed the checklist goal! +{GetPoints() + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Progress: {_amountCompleted}/{_target} (+{GetPoints()} points)");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }
}
