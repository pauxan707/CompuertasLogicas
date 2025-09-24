namespace Library;

public class TrueGate : ILogicGate
{
    public string Name { get; set; }

    public TrueGate(string name)
    {
        Name = name;
    }

    public bool Evaluate()
    {
        return true;
    }
}
