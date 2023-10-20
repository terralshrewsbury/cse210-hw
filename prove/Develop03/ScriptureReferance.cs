public class ScriptureReference
{
    private string _referance {get; }

    public ScriptureReference(string referance)
    {
        _referance= referance;
    }

    public string referanceAsString()
    {
        return _referance;
    }
}

