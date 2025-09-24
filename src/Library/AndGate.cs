namespace Library;

public class AndGate: ILogicGate
{
    public string Name { get; set; }
    public List<ILogicGate> Inputs = new List<ILogicGate>();

    public AndGate(string name)
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
            if (!gate.Evaluate())
                return false;
        }

        return true;
    }
}
