using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab7b_FirstNode.ConsoleApp
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

            // ToDo: 0 - Run once. Create a stream called "lab6b" for passing raw transactions.
            //try
            //{
            //    json = create stream "lab7b";
            //    json = subscribe stream "lab7b";
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Created stream 'lab7b'.");
            //Console.ReadLine();


            //ToDo: 1 - preparelockunspent qty of asset to offer
            //string offerAssetname = "asset1";
            //int offerQty = 1;
            //string txid = "";
            //int vout = 0;
            //try
            //{
            //    json = prepareLockUnspent offerAssetname offerQty
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var preparelockunspent = JsonRpcClient.Get(json);
            //    txid = preparelockunspent.txid;
            //    vout = preparelockunspent.vout;
            //}
            //catch { throw; }
            //Console.WriteLine("Locked offer {0} x {1}", offerAssetname,offerQty);
            //Console.ReadLine();

            //ToDo: 2 - createrawexchange with qty of asset to ask
            //string askAssetname = "asset2";
            //int askQty = 1;
            //string hex = "";
            //try
            //{
            //    json = create raw exchange txid,vout,askAssetname,askQty
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var createrawexchange = JsonRpcClient.Get(json);
            //    hex = createrawexchange;
            //}
            //catch { throw; }
            //Console.WriteLine("Created transaction to offer {0} x {1} and ask {2} x {3}", offerAssetname, offerQty,askAssetname,askQty);
            //Console.ReadLine();

            //ToDo: 3 - publish raw transaction to stream "lab7b"
            //try
            //{
            //    json = publish to stream hex to "labl7b" using key DateTime.Now.ToString()
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Transaction published to stream.");
            //Console.ReadLine();

        }
    }
}
