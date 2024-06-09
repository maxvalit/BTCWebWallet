namespace BTCWebWallet.RPCClient;

public class DumpWalletResponse : RPCResponse<DumpWalletResult>
{

}

public class LoadWalletResponse:RPCResponse<LoadWalletResult>{}

public class LoadWalletResult
{
    public string Name { get; set; }
    public string Warning { get; set; }
}