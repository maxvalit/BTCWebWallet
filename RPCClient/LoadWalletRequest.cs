namespace BTCWebWallet.RPCClient;

public class LoadWalletRequest : RPCRequest
{
    private const string method_name = "loadwallet";

    public LoadWalletRequest(string id,string fileName) : base(method_name, id)
    {
        FileName = fileName;
    }

    public LoadWalletRequest(string fileName) : base(method_name)
    {
        FileName = fileName;
    }

    public string FileName { get; set; }

    public override List<object> Params
    {
        get
        {
            var retval = new object[]
            {
                FileName
            };

            return retval.ToList();
        }
    }
}