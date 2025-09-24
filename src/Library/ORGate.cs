namespace Library;

public class OrGate : ILogicGate
{
    public string Name { get; set; }
    public List<ILogicGate> Inputs { get; } = new List<ILogicGate>();

    public OrGate(string name)
    {
        Name = name;
    }

    public void AddInput(ILogicGate gate)
    {
        Inputs.Add(gate);
    }

    public bool Evaluate()
    {
        foreach (ILogicGate gate in Inputs)
        {
            if (gate.Evaluate())
                return true;
        }
        return false;
    }
}
