using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.MultichainLib
{
    public class TransactionManager : ServiceBase
    {
        public TransactionManager(JsonRpcClient c) : base(c)
        {

        }

        public string CreateRawSendFrom(string addressFrom, string addressTo, string assetname, int qty)
        {
            return jsonRpcClient.JsonRpcRequest("createrawsendfrom", addressFrom, new Dictionary<string, object> { { addressTo, new Dictionary<string, int> { { assetname, qty } } } }, null, "sign");
        }

        public string SignRawTransaction(string hex)
        {
            throw new NotImplementedException();
        }
        public string SendRawTransaction(string hex)
        {
            throw new NotImplementedException();
        }
        public string GetTxOutData(string txid, int vout)
        {
            throw new NotImplementedException();
        }
        public string DecodeRawTransaction(string hex)
        {
            throw new NotImplementedException();
        }
        public string ListAddressTransactions(string address, int count)
        {
            throw new NotImplementedException();
        }
        public string CreateRawExchange(string txid, int vout, string assetname, int qty)
        {
            throw new NotImplementedException();
        }
        public string AppendRawExchange(string hex, string txid, int vout, string assetname, int qty)
        {
            throw new NotImplementedException();
        }
        public string DecodeRawExchange(string hex)
        {
            throw new NotImplementedException();
        }

    }
}
