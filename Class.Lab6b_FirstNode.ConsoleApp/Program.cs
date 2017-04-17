using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab6b_FirstNode.ConsoleApp
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

            // ToDo: 0 - Run once. Create a stream called "lab6b" for passing raw transactions.
            //try
            //{
            //    json = streamMgr.CreateStream("lab6b");
            //    json = streamMgr.SubscribeStream("lab6b");
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Created stream 'lab6b'.");
            //Console.ReadLine();

            // ToDo: 1 - Initialize these values
            string address1 = "1XQi7AwVgbTFRiagukhJptBuPwkqCGTYHWtWGS";
            string address2 = "1EBPBxJwTNjPzviJP7EBqWj3i29nzQkx9EaYnM";
            string address3 = "1DvVJzHYsDZTCyh8PUvgYPrJggpNaNSqzEAaMM";
            string pubkey1 = "03c4cef86183a53bee988c83feeb9f8bdd22de98a0127893db5645a7d94adc1ccf";
            string pubkey2 = "029a6c010b37db7338429ac467d0260e5749006672f842c76a4143c9d2be411577";

            //permissionMgr.Grant(address2, "lab6b.write");

            // ToDo: 2 - addmultisigaddress 2-of-2 
            //string multisig = "";
            //try
            //{
            //    json = addressMgr.AddMultisigAddress(2, pubkey1, pubkey2);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    multisig = JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Created multisig address." + multisig);
            //Console.ReadLine();

            // ToDo: 3 - grant multisig address send,receive permission
            //try
            //{
            //    json = grant read write permission to multichain address
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Granted permission to multisig address.");
            //Console.ReadLine();

            // ToDo: 4 - Check multichain-cli to confirm address exists.

            // ToDo: 5 - issueasset to multisig address
            //try
            //{
            //    json =   issueasset asset113 to multisig address
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Issued asset to multisig address.");
            //Console.ReadLine();

            // ToDo: 6 - Check multichain-cli to confirm asset balance in multisig address

            // ToDo: 7 - createrawsendfrom to send asset from multisig address to third node.
            //string hex = "";
            //try
            //{
            //    json = txnMgr.CreateRawSendFrom(multisig, address3, "asset113", 10);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var createrawsendfrom = JsonRpcClient.Get(json);

            //    //refer to slide #28
            //    hex = createrawsendfrom.hex;
            //}
            //catch { throw; }
            //Console.WriteLine("Node1: Created raw transaction. Check address balance. Amount should be locked.");
            //Console.ReadLine();

            // ToDo: 8 - Check multichain-cli to confirm asset balance in multisig address. Asset balance should be reduced.

            // ToDo: 9 - publish raw transaction to stream
            //try
            //{
            //    json =  publish hex to "lab6b" using the key DateTime.Now.ToString()
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Published signed transaction.");
            //Console.ReadLine();

        }
    }
}
