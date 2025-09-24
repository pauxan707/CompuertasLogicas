namespace Library;

public class FalseGate : ILogicGate
{
    public string Name { get; set; }

    public FalseGate(string name)
    {
        Name = name;
    }

    public bool Evaluate()
    {
        return false;
    }

}