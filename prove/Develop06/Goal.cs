 public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(); // Abstract method to be overridden
    public abstract bool IsComplete(); // Abstract method to be overridden
    public virtual string GetDetailsString() // Base implementation
    {
        return $" {_shortName}: {_description}";
    }
    public abstract string GetStringRepresentation(); // Abstract method to be overridden
}
