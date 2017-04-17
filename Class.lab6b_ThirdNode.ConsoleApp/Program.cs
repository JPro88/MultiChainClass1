using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.lab6b_ThirdNode.ConsoleApp
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
            //string address3 = "1DvVJzHYsDZTCyh8PUvgYPrJggpNaNSqzEAaMM";
            //string json = "";

            // ToDo: 1 - Wait for Second Node to complete

            // ToDo: 2 - use multichain-cli check address balance to confirm receipt of asset

            // ToDo: 3 - listaddresstransactions to get the details of last transactions
            //try
            //{
            //    json = txnMgr.ListAddressTransactions(address3, 1);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Displayed last transactions.");
            //Console.ReadLine();

            // ToDo: 4 - getaddressbalances to confirm receipt of asset
            //try
            //{
            //    json = assetMgr.GetAddressBalances(address3);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Displayed asset balances transactions.");
            //Console.ReadLine();

        }
    }
}
