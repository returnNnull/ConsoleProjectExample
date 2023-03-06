namespace ConsoleProjectExample;

public class Employer : Model
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }
    
    public User User { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(BirthDay)}: {BirthDay}, {nameof(User)}: {User}";
    }
}