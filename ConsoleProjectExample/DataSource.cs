namespace ConsoleProjectExample;

public class DataSource<T> where T : Model
{
    private List<T> Items = new();

    public List<T> GetAll() => Items;

    public void Add(T t) => Items.Add(t);

    public void Delete(T t) => Items.Remove(t);

    public void GetById(int id) => Items.FirstOrDefault(t => t.Id == id);
}