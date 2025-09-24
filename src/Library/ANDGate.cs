namespace Library;

public class ANDGate: ILogicGate
{
    public string Name { get; set; }
    public List<ILogicGate> Inputs = new List<ILogicGate>();

    public ANDGate(string name)
    {
        Name = name;
    }

    public void AddInput(ILogicGate gate)
    {
        Input.Add(gate);
    }

    public IGate Evaluate()
    {
        foreach (ILogicGate gate in Inputs)
        {
            if (!gate.Evaluate())
                return false;
        }

        return true;
    }
}
