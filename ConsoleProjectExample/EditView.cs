using ConsoleProjectExample.Navigation;

namespace ConsoleProjectExample;

public class EditView<T> : View
{
    public T _item { get; set; }

    public EditView(T t)
    {
        _item = t;
    }

    public override void Show()
    {
        Console.WriteLine(_item);
    }

    public void ShowFieldsValue(Dictionary<string, string> values)
    {
        foreach (var variable in values)
        {
            Console.WriteLine($"{variable.Key}. {variable.Value}");
        }
        
    }


}