namespace Library;

public class NOTGate: ILogicGate
{
    public string Name { get; set; }
    public ILogicGate Input;

    public NotGate(string name, ILogicGate input)
    {
        Name = name;
        Input = input;
    }
    
    public bool Evaluate()
    {
        return !Input.Evaluate();
    }
}
