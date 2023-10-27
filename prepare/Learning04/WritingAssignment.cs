public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentsName, string topic, string title):base (studentsName, topic)
    {
        _title = title;
    }
    
   

    public string GetWritingHomework()
    {
        string studentsName = GetName();
        return $"{_title} by {studentsName}";
    }

}