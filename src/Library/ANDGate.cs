namespace Library;

public class ANDGate: IGate
{
    public string Name { get; set; }
    public List<IGate> Input = new List<IGate>();
    public IGate Output { get; set; }

    public ANDGate(string name)
    {
        Name = name;
    }

    public void AddInput(IGate iGate)
    {
        Input.Add(iGate);
    }

    public IGate Evaluate()
    {
        foreach (IGate element in this.Input)
        {
            if (element == false)
            {
                
            }
        }
        
    }
}
