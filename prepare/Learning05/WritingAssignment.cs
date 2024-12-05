public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)//constructor
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation(string studentName)
    {

        return $"{_title} by {studentName}";
    }
}