using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab8b_SecondNode.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToDo: 0 - Purpose of this lab is to create encrypted streams. Work as a team and take turns to run as first node and second node. Third node can use multichain-cli to observe the content of item stream and download it to verify.
            //JsonRpcClient jsonRpcClient = new JsonRpcClient(your rpc user name, your rpc password, node network ip, node port number, chain name);
            //AddressManager addressMgr = new AddressManager(jsonRpcClient);
            //PermissionManager permissionMgr = new PermissionManager(jsonRpcClient);
            //AssetManager assetMgr = new AssetManager(jsonRpcClient);
            //TransactionManager txnMgr = new TransactionManager(jsonRpcClient);
            //StreamManager streamMgr = new StreamManager(jsonRpcClient);
            //string json = "";
            //string address1 = "1XQi7AwVgbTFRiagukhJptBuPwkqCGTYHWtWGS";


            // ToDo: 0 - Subscribe to 3 streams called "pubkeys","labl8b" and "access".
            //try
            //{
            //    subscribe stream "pubkeys"
            //    subscribe stream "lab8b"
            //    subscribe stream "access"
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Subscribed to streams 'lab8b','pubkeys',access'");
            //Console.ReadLine();


            // ToDo: 1 - generate secret and save to file
            //try
            //{
            //    string secret = CryptoHelper.GenerateAESKey();
            //    File.WriteAllText("secret.txt", secret);
            //}
            //catch { throw; }
            //Console.WriteLine("AES key successfully generated into 'secret.txt' file.");
            //Console.ReadLine();

            // ToDo: 2 - encrypt content (bin) using secret key (base64) and publish to "items" stream (hex)
            //try
            //{
            //    string secret = File.ReadAllText("secret.txt");
            //    string encrypted = CryptoHelper.EncryptAES(File.ReadAllBytes("tut.jpg"), secret);
            //    string hex = Hex.Base642Hex(encrypted);
            //    json = publish hex to stream "lab8b" using the key "tut"
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Content successfully encrypted using secret key and uploaded to stream");
            //Console.ReadLine();

            // ToDo: 3 - Subscribe to pubkey stream, retrieve First Node's public key (Hex) and save to PEM encoded file (UTF8)
            //try
            //{
            //    json =  List stream items from "pubkeys" published by first node's address
            //    var liststreampublisheritem = JsonRpcClient.Get(json);
            //    string hex = liststreampublisheritem[liststreampublisheritem.Count - 1].data;
            //    var pubkey = Hex.Hex2UTF8(hex);
            //    File.WriteAllText(address1 + ".pem", pubkey);
            //}
            //catch { throw; }
            //Console.WriteLine("First Node's public key is successfully downloaded from stream 'pubkeys' and saved to {node1-address}.pem file.");
            //Console.ReadLine();


            // ToDo: 4 - encrypt the secret key (Base64) with First Node's RSA public key (UTF8) and publish to "access" stream (Hex)
            //try
            //{
            //    var pubkey = File.ReadAllText(address1 + ".pem");
            //    var secret = File.ReadAllText("secret.txt");
            //    var encrypted = CryptoHelper.EncryptRSA(secret, pubkey);
            //    var hex = Hex.Base642Hex(encrypted);
            //    json = streamMgr.PublishStream("access", "tut-"+address1,hex);
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("secret key successfully encrypted using First Node's public key and published to 'access' stream using 'tut-' + First Node's address as key.");
            //Console.ReadLine();

        }
    }
}
