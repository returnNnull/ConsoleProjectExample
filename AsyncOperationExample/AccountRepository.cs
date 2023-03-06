namespace AsyncOperationExample;

public class AccountRepository
{
    private Server _server;
    private FileSystem _fileSystem;

    public AccountRepository(Server server, FileSystem fileSystem)
    {
        _server = server;
        _fileSystem = fileSystem;
    }

    public async Task<Account> GetAccount()
    {
        var accountDto = await _server.GetAccount();
        var file = await _fileSystem.GetFromPath(accountDto.Img);

        return new Account()
        {
            Id = accountDto.Id,
            Name = accountDto.Name,
            File = file
        };
    }
    
}