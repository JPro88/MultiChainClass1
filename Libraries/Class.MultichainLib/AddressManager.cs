using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.MultichainLib
{
    public class AddressManager : ServiceBase
    {
        public AddressManager(JsonRpcClient c) : base(c)
        {

        }

        public string GetAddresses()
        {
            return jsonRpcClient.JsonRpcRequest("getaddresses", true);
        }

        public string GetNewAddress()
        {
            throw new NotImplementedException();
        }

        public string ImportAddress(string address)
        {
            throw new NotImplementedException();
        }

        public string AddMultisigAddress(int nrequired, params string[] pubkeys)
        {
            throw new NotImplementedException();
        }


    }
}
