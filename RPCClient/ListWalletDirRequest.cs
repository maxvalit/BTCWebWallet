namespace BTCWebWallet.RPCClient;

public class ListWalletDirRequest : RPCRequest
{
    private const string method_name = "listwalletdir";

    public ListWalletDirRequest(string id) : base(method_name, id)
    {
        
    }

    public ListWalletDirRequest() : base(method_name) 
    {

    }
}