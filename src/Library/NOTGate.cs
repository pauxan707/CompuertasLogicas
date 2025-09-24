namespace Library;

public class NOTGate: ILogicGate
{
    public string Name { get; set; }
    public List<ILogicGate> Inputs = new List<ILogicGate>();

    public ANDGate(string name)
    {
        Name = name;
    }

    public void AddInput(ILogicGate gate)
    {
        Inputs.Add(gate);
    }

    public IGate Evaluate()
    {
        return !Input.Evaluate();
    }
}
