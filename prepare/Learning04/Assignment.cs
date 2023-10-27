public class Assignment
{
    private string _studentsName;
    private string _topic;

     public Assignment(string studentsName, string topic)
     {
        _studentsName = studentsName;
        _topic = topic;
     }

    public string GetSummary(){
        return _studentsName + " - " + _topic;
    }

    public string GetName(){
        return _studentsName;
    }







}