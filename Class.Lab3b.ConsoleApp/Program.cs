using Class.MultichainLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab3b.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //ToDo: 0 - The purpose for this lab is to show the use of assets.
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //AssetManager assetMgr = new AssetManager(jsonRpcClient);
            //string json = "";

            //ToDo: 1 - Run once. issueasset to yourself "asset112" (or other name if its already used) qty=5000 unit=0.1 with a note called "lab3b". Take note of how anonymous type is used in IssueAsset method.
            //try
            //{
                //json = assetMgr.IssueAsset(your address, "asset112", 1000, 1, "demo");
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Issued new assets.");
            //Console.ReadLine();

            //ToDo: 2 - listasset to confirm assets issued
            //try
            //{
                //json = assetMgr.ListAssets("asset112",false);
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Displayed asset details.");
            //Console.ReadLine();

            //ToDo: 3 - getaddressbalances to check your balance
            //try
            //{
                //json = assetMgr.GetAddressBalances(your address);
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Displayed address balances.");
            //Console.ReadLine();


            //ToDo: 4 - sendasset to someone and getaddressbalances again.
            //try
            //{
            //    json = assetMgr.SendAsset(Somebody's address, "asset112", 10);
            //    json = assetMgr.GetAddressBalances(your address);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Asset sent to someone and display address balances again.");
            //Console.ReadLine();

            //ToDo: 5 - issuemore "asset112" and confirm total assets issued again.
            //try
            //{
            //    json = assetMgr.IssueMore(your address, "asset112", 10);
            //    json = assetMgr.ListAssets("asset112",false);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Issued more assets and show asset details again.");
            //Console.ReadLine();
        }
    }
}
