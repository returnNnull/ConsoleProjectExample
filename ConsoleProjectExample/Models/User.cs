namespace ConsoleProjectExample;

public class User : Model
{
    public string Login { get; set; }
    public string Password { get; set; }
    public List<Role> Roles { get; set; } = new();

    public override string ToString()
    {
        return $"{nameof(Login)}: {Login}, {nameof(Password)}: {Password}, {nameof(Roles)}: {GetRolesCollectionStrings()}";
    }

    private string GetRolesCollectionStrings()
    {
        var result = Roles.Aggregate("[", (current, variable) => current + $"{variable.Value}, ");
        return  result.Remove(result.Length - 2) + "]";
    }
}