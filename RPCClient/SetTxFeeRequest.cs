using System.Globalization;

namespace BTCWebWallet.RPCClient;

public class SetTxFeeRequest : RPCRequest
{
    private const string method_name = "settxfee";
    public SetTxFeeRequest(decimal amount, string id) : base(method_name, id)
    {
        Amount = amount.ToString(CultureInfo.InvariantCulture);
    }
    
    public string Amount { get; set; }
    public override List<object> Params
    {
        get
        {
            var retval = new object[]
            {
                Amount
            };

            return retval.ToList();
        }
    }
}