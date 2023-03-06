using ConsoleProjectExample.Navigation;

namespace ConsoleProjectExample;

public class ListView<T>: View
{
    private List<T> Items;
    public string Header { get; set; }

    public ListView()
    {
        Items = new();
    }

    public ListView(List<T> items)
    {
        Items = items;
    }

    public override void Show()
    {
        Console.WriteLine(Header);
        for (var i = 0; i < Items.Count; i++)
        {
            Console.WriteLine($"{i}. {Items[i]}");
        }
    }

    public T GetByPosition(int position) => Items[position];

    public void Add(T t) => Items.Add(t);

    public void Remove(T t) => Items.Remove(t);
}