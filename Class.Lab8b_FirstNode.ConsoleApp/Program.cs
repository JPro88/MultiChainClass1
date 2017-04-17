using Class.MultichainLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab8b_FirstNode.ConsoleApp
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

            // ToDo: 0 - Run once. Create 3 stream called "pubkeys","labl8b" and "access".
            //try
            //{
            //    create stream "pubkeys" permission not required
            //    subscribe stream "pubkeys"
            //    create stream "lab8b" permission not required
            //    subscribe stream "lab8b"
            //    create stream "access" permission not required
            //    subscribe stream "access"
            //    Console.WriteLine(JsonRpcClient.Indent(json));
            //    JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("Created streams 'lab8b','pubkeys',access'");
            //Console.ReadLine();

            // ToDo: 0 - Run once. Generate RSA keypairs. Save to PEM encoded files (UTF8).
            //try
            //{
                //var keypair = CryptoHelper.GenerateRSAKeyPair();
                //string pubPem = CryptoHelper.GetRSAPublicKey(keypair);
                //File.WriteAllText("pubkey.pem", pubPem);
                //string privPem = CryptoHelper.GetRSAPrivateKey(keypair);
                //File.WriteAllText("privkey.pem", privPem);
            //}
            //catch { throw; }
            //Console.WriteLine("RSA key pair successfully created in pubkey.pem and privkey.pem files.");
            //Console.ReadLine();

            // ToDo: 0 - Run once. publish rsa public key to 'pubkey' stream.
            //try
            //{
                //// Read from PEM encoded file and to hexadecimal
                //var pubPem = File.ReadAllText("pubkey.pem");
                //string hex = Hex.UTF82Hex(pubPem);
                //json = streamMgr.PublishStream("pubkeys", "", hex);
                //Console.WriteLine(JsonRpcClient.Indent(json));
                //JsonRpcClient.Get(json);
            //}
            //catch { throw; }
            //Console.WriteLine("RSA public key successfully published to 'pubkeys' stream.");
            //Console.ReadLine();

            // ToDo: 1 - Wait for Second Node to publish encrypted key


            // ToDo: 2 - Retrieve the encrypted secret from "access" stream using the stream item key "tut-"+ First Node's address and decrypt into AES key file
            //string secret = "";
            //try
            //{
                //json = streamMgr.ListStreamKeyItem("access", "tut-" + address1);
                //var liststreamkeyitem = JsonRpcClient.Get(json);
                //var encrypted = liststreamkeyitem[liststreamkeyitem.Count - 1].data.ToString();
                //var privKey = File.ReadAllText("privkey.pem");
                //secret = CryptoHelper.DecryptRSA(Hex.Hex2Base64(encrypted), privKey);
                //File.WriteAllText("secret2.txt", secret);
            //}
            //catch { throw; }
            //Console.WriteLine("Encrypted secret key successfully downloaded and decrypted using Node1 private key into 'secret2.txt'");
            //Console.ReadLine();


            // ToDo: 3
            /// Retrieve the AES encrypted item from 'lab8b' stream with the stream item key 'tut-'+First Node's address. Decrypt using secret and save to binary.
            //try
            //{
            //    json = list stream item from "lab8b" using the key "tut";
            //    var liststreamkeyitem = JsonRpcClient.Get(json);

            //    var data = liststreamkeyitem[liststreamkeyitem.Count - 1].data;
            //    if (data.txid!=null)
            //    {
            //        json = get txout data using txid and vout
            //        data = JsonRpcClient.Get(json);
            //    }
            //    var decrypted = CryptoHelper.DecryptAES(Hex.Hex2Base64(data.ToString()), secret);
            //    var bytes = Hex.Base642Bytes(decrypted);
            //    File.WriteAllBytes("tut2.jpg", bytes);
            //}
            //catch { throw; }
            //Console.WriteLine("Content successfully downloaded from stream and decrypted into binary file tut2.jpg.");
            //Console.ReadLine();
        }
    }
}
