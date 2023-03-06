namespace ConsoleProjectExample;

public class Role : Model
{
    public string Value { get; set;}

    public override string ToString()
    {
        return $"{nameof(Value)}: {Value}";
    }
}