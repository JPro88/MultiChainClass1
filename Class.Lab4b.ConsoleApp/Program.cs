using Class.MultichainLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab4b.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //ToDo: 0 - The purpose of this lab is to show the use of streams
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //StreamManager streamMgr = new StreamManager(jsonRpcClient);
            //string json = "";

            //ToDo: 1 - Run once. create stream "stream111", replace the stream name if necessary
            //try
            //{
                //json = streamMgr.CreateStream("stream112");
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Created new stream.");
            //Console.ReadLine();


            //ToDo: 2 - Read a sample binary file and publish to stream with the key "boo"
            //try
            //{
            //    var bytes = File.ReadAllBytes("boo.jpg");
            //    var filedata = Hex.Bytes2Hex(bytes);
            //    json = streamMgr.PublishStream("stream112", "boo", filedata);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Published binary file content to stream.");
            //Console.ReadLine();

            //ToDo: 3 - Subscribe to the stream to view content
            //try
            //{
            //    json = streamMgr.SubscribeStream("stream112");
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Subscribed to stream.");
            //Console.ReadLine();

            //ToDo: 4 - getstreamkeyitem to find stream item using the key "boo"
            //string data = "";
            //try
            //{
            //    json = streamMgr.ListStreamKeyItem("stream112", "boo");
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var getstreamkeyitem = JsonRpcClient.Get(json);

            //    // Refer to slide# 28. Get data from last item of the array.
            //    data = getstreamkeyitem[getstreamkeyitem.Count - 1].data;
            //}
            //catch { throw; }
            //Console.WriteLine("Retrieved file content from stream.");
            //Console.ReadLine();

            //ToDo: 5 - Save the data to file "boo2.jpg" under the [project]\bin\Debug directory. Open the file and confirm success.
            //try
            //{
            //    var bytes = Hex.Hex2Bytes(data);
            //    File.WriteAllBytes("boo2.jpg", bytes);
            //}
            //catch { throw; }
            //Console.WriteLine("Content saved to file.");
            //Console.ReadLine();

            //ToDo: 6 - Read a larger sample binary file (size more than max-std-element-size and publish to stream with the key "cats"
            //try
            //{
            //    var bytes = File.ReadAllBytes("cats.jpg");
            //    var filedata = Hex.Bytes2Hex(bytes);
            //    json = streamMgr.PublishStream("stream112", "cats", filedata);
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Published binary file content to stream.");
            //Console.ReadLine();

            //ToDo: 7 - getstreamkeyitem to find stream item using the key "cats"
            //try
            //{
            //    json = streamMgr.ListStreamKeyItem("stream112", "cats");
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    var getstreamkeyitem = JsonRpcClient.Get(json);

                // Refer to slide# 28. Get data from last item of the array.
                //var data2 = getstreamkeyitem[getstreamkeyitem.Count - 1].data;

                // If the data is larger than max-std-element-size, data will be replaced with a reference to a different transaction outpoint given by txid and vout
            //    if (data2.txid!=null)
            //    {
            //        string txid = data2.txid;
            //        int vout = data2.vout;
            //        TransactionManager txnMgr = new TransactionManager(jsonRpcClient);
            //        json = txnMgr.GetTxOutData(txid, vout);
            //        data = JsonRpcClient.Get(json);
            //    }
            //}
            //catch { throw; }
            //Console.WriteLine("Retrieved file content from stream.");
            //Console.ReadLine();

            //ToDo: 8 - Save the data to file "cats2.jpg" under the [project]\bin\Debug directory. Open the file and confirm success.
            //try
            //{
            //    var bytes = Hex.Hex2Bytes(data);
            //    File.WriteAllBytes("cats2.jpg", bytes);
            //}
            //catch { throw; }
            //Console.WriteLine("Content saved to file.");
            //Console.ReadLine();

            //ToDo: 9 - Work with your team and publish the data onto their stream. They must provide you with permission to write.
        }
    }
}
