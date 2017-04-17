using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab2b.ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //ToDo: 0 - The purpose of this lab is to learn how to send basic commands using MultiChain JSON-RPC API. This is not a C# class but basic familiarity is required for later more complex use cases.
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //Admin admin = new Admin(jsonRpcClient);
            //PermissionManager permissionMgr = new PermissionManager(jsonRpcClient);
            //AddressManager addressMgr = new AddressManager(jsonRpcClient);
            //string json = "";

            //ToDo: 1 - "getinfo"
            //string blocks = "";
            //try
            //{
                //json = admin.GetInfo();
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //var getinfo = JsonRpcClient.Get(json);

                // refer to slide #77
                //blocks = get block height from getinfo
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 2 - "getpeerinfo"
            //try
            //{
                //json = admin.GetPeerInfo();
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 3 - "getblock"
            //try
            //{
                //json = admin.GetBlock(blocks);
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch{throw;}
            //Console.ReadLine();

            //ToDo: 4 - "getblockchainparams"
            //try
            //{
                //json = admin.GetBlockchainParams();
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 5 - "getaddresses true"
            //try
            //{
                //json = addressMgr.GetAddresses();
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 6 - "listpermissions"
            //try
            //{
                //json = permissionMgr.ListPermissions();
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 7 - "listpermissions admin"
            //try
            //{
                //json = permissionMgr.ListPermissions("admin");
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 8 - "listpermissions * * true"
            //try
            //{
                //json = permissionMgr.ListPermissions("*", "*");
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

            //ToDo: 9 - "grant address connect,issue,create"
            //try
            //{
                //json = permissionMgr.Grant(someone's address, "connect,issue,create");
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.ReadLine();

        }
    }
}
