namespace AsyncOperationExample;

public class Server
{
    public async Task<AccountDTO> GetAccount()
    {
        await Task.Delay(1000);
        return new AccountDTO()
        {
            Id = 0,
            Name = "Igor",
            Img = "/image"
        };
    }
}