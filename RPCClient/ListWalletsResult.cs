namespace BTCWebWallet.RPCClient;

public class ListWalletsResult : List<string>
{

}

public class ListWalletDirResult
{
    public List<WalletDto> Wallets { get; set; }
}

public record WalletDto(string Name);