using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab6b_SecondNode.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToDo: 0 - Purpose of this lab is to use multisignature address. Work as a team and take turns to run as first node, second node and third nodes.
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //AddressManager addressMgr = new AddressManager(jsonRpcClient);
            //PermissionManager permissionMgr = new PermissionManager(jsonRpcClient);
            //AssetManager assetMgr = new AssetManager(jsonRpcClient);
            //TransactionManager txnMgr = new TransactionManager(jsonRpcClient);
            //StreamManager streamMgr = new StreamManager(jsonRpcClient);
            //string json = "";
            //string address1 = "1XQi7AwVgbTFRiagukhJptBuPwkqCGTYHWtWGS";

            // ToDo: 1 - Wait for First Node to complete

            // ToDo: 2 - subscribe to stream "lab6b"
            //try
            //{
            //    json = subscribe to stream lab6b
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("subscribed to stream 'lab6b'.");
            //Console.ReadLine();

            // ToDo: 3 - getstreampublisheritems from stream using First Node's address
            //string hex = "";
            //try
            //{
            //    json = streamMgr.ListStreamPublisherItem("lab6b",address1);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var getstreampublisheritems = JsonRpcClient.Get(json);
            //    hex = getstreampublisheritems[getstreampublisheritems.Count - 1].data;
            //}
            //catch { throw; }
            //Console.WriteLine("Retrieved partially signed raw transaction");
            //Console.ReadLine();

            // ToDo: 4 - decoderawtransaction
            //try
            //{
            //    json = txnMgr.DecodeRawTransaction(hex);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Decoded raw transaction");
            //Console.ReadLine();

            // ToDo: 5 - signrawtransaction
            //try
            //{
            //    json = txnMgr.SignRawTransaction(hex);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var signrawtransaction = JsonRpcClient.Get(json);
            //    hex = signrawtransaction.hex;
            //}
            //catch { throw; }
            //Console.WriteLine("Signed and complete transaction");
            //Console.ReadLine();

            // ToDo: 6 - sendrawtransaction
            //try
            //{
            //    json = txnMgr.SendRawTransaction(hex);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Sent transaction");
            //Console.ReadLine();


        }
    }
}
