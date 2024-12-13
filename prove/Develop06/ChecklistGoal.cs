public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete++;
            int earnedPoints = _points;
            if (_amountComplete == _target)
            {
                earnedPoints += _bonus;  // Bonus for completion
                Console.WriteLine($"Congratulations! You've completed the goal: {_shortName} and earned the bonus!");
            
            }
            Console.WriteLine($"Goal '{_shortName}' completed {_amountComplete}/{_target}. You earned {earnedPoints} points for completing this goal.");
        } 
    }

    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }

    public override string GetDetailsString()
    {
        return $" {_shortName}: {_description} (Completed {_amountComplete}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountComplete},{_target},{_bonus}";
    }
}
