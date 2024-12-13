public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal Goal '{_shortName}' recorded! You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    public override string GetStringRepresentation()
    {
         return $"{_shortName},{_description},{_points},false";
    }
}
