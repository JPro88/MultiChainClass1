using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab7b_SecondNode.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToDo: 0 - Purpose of this lab is to use atomic exchange. Work as a team and take turns to run as first node and second node. Third node can use multichain-cli to observe.
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //AddressManager addressMgr = new AddressManager(jsonRpcClient);
            //PermissionManager permissionMgr = new PermissionManager(jsonRpcClient);
            //AssetManager assetMgr = new AssetManager(jsonRpcClient);
            //TransactionManager txnMgr = new TransactionManager(jsonRpcClient);
            //StreamManager streamMgr = new StreamManager(jsonRpcClient);
            //string json = "";
            //string address1 = "1XQi7AwVgbTFRiagukhJptBuPwkqCGTYHWtWGS";

            // ToDo: 1 - Wait for First Node to complete

            // ToDo: 2 - subscribe to stream "lab7b"
            //try
            //{
            //    json = subscribe to stream "lab7b"
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("subscribed to stream 'lab7b'.");
            //Console.ReadLine();

            // ToDo: 3 - getstreampublisheritems from stream using First Node's address
            //string hex = "";
            //try
            //{
            //    json = streamMgr.ListStreamPublisherItem("lab7b", address1);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var getstreampublisheritems = JsonRpcClient.Get(json);
            //    hex = getstreampublisheritems[getstreampublisheritems.Count - 1].data;
            //}
            //catch { throw; }
            //Console.WriteLine("Retrieved partially signed raw exchange");
            //Console.ReadLine();

            // ToDo: 4 - decoderawexchange and retrieve First Node's ask and offer.
            //string offerAsset = "";
            //int offerQty = 0;
            //string askAsset = "";
            //int askQty = 0;
            //try
            //{
            //    json = Decoder raw exchange hex
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var decoderawexchange = JsonRpcClient.Get(json);
            //    offerAsset = decoderawexchange.ask.assets[0].name;
            //    offerQty = decoderawexchange.ask.assets[0].qty;
            //    askAsset = decoderawexchange.offer.assets[0].name;
            //    askQty = decoderawexchange.offer.assets[0].qty;
            //}
            //catch { throw; }
            //Console.WriteLine("Decoded raw exchange");
            //Console.ReadLine();

            // ToDo: 5 - preparelockunspent qty of asset to offer to match First Node's ask
            //string txid = "";
            //int vout = 0;
            //try
            //{
            //    json = // prepare lock unspent offerAsset offerQty
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var preparelockunspent = JsonRpcClient.Get(json);
            //    txid = preparelockunspent.txid;
            //    vout = preparelockunspent.vout;
            //}
            //catch { throw; }
            //Console.WriteLine("Lock qty of asset to offer");
            //Console.ReadLine();

            // ToDo: 6 - appendrawexchange qty of asset to ask to match First Node's offer
            //try
            //{
            //    json = append raw rxchange hex txid vout askAsset askQty;
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var appendrawexchange = JsonRpcClient.Get(json);
            //    hex = appendrawexchange.hex;
            //}
            //catch { throw; }
            //Console.WriteLine("Lock qty of asset to offer");
            //Console.ReadLine();

            // ToDo: 7 - decoderawexchange to review the exchange
            //try
            //{
            //    json = decode raw exchange hex;
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Decoded raw final exchange");
            //Console.ReadLine();

            // ToDo: 8 - sendrawtransaction to complete the exchange
            //try
            //{
            //    json = send raw transaction hex;
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("transaction sent");
            //Console.ReadLine();



        }
    }
}
