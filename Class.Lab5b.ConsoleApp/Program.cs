using Class.MultichainLib;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lab5b.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// A method that generates a compressed/uncompressed public key using secp256k1 ECDSA curve
        /// </summary>
        /// <param name="privateKey"></param>
        /// <param name="useCompression"></param>
        /// <returns></returns>
        static string GeneratePublicKey(string privateKey, bool useCompression)
        {
            return CryptoHelper.GenerateSecp256k1PublicKey(privateKey, useCompression);
        }

        /// <summary>
        /// A method that returns a byte array from hexadecimal string
        /// </summary>
        /// <param name="privateKey"></param>
        /// <param name="useCompression"></param>
        /// <returns></returns>
        public static byte[] GetBytesFromHexString(string hex)
        {
            return Hex.Hex2Bytes(hex);
        }

        /// <summary>
        /// A method that computes a SHA256 digest of a string
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        static string SHA256(string target)
        {
            return CryptoHelper.SHA256(target);
        }

        /// <summary>
        /// A method that computes a RIPEMD160 hash of a string
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        static string RIPEMD160(string target)
        {
            return CryptoHelper.RIPEMD160(target);
        }

        static string InsertAddressPubKeyHashVersion(string pubkeyHash, string addressPubKeyHashVersion)
        {
            var bytes = MultichainHelper.InsertAddressVersion(pubkeyHash, addressPubKeyHashVersion);
            return Hex.Bytes2Hex(bytes);
        }

        static string CreateXorChecksum(string pubkeyHash, string addressChecksumValue)
        {
            var bytes = Hex.XOR(pubkeyHash, addressChecksumValue);
            return Hex.Bytes2Hex(bytes);
        }


        /// <summary>
        /// A method that returns Base58 Encoded string of a hexadecimal string
        /// </summary>
        /// <param name="args"></param>
        static string Base58(string target)
        {
            var bytes = GetBytesFromHexString(target);
            return CryptoHelper.EncodeBase58(bytes, 0, bytes.Length);
        }

        static void Check(string target, string result, string message)
        {
            if (target == result)
                Console.WriteLine(message + " = " + result + " is correct");
            else
            {
                Console.WriteLine(message + " is wrong");
                Console.WriteLine("Expected:" + target);
                Console.WriteLine("Result:" + result);
            }
        }

        static void Main(string[] args)
        {
            // ToDo: Refer to https://en.bitcoin.it/wiki/Technical_background_of_version_1_Bitcoin_addresses
            // Make use of the methods provided above and reproduce the steps to create a bitcoin address

            //ToDo: PartI- 0 - Start with a private ECDSA key (retrieve it from the link)
            string privateKey = "";

            //ToDo: 1 – Generate public key
            var pubkey = "";
            Check("0284E5235E299AF81EBE1653AC5F06B60E13A3A81F918018CBD10CE695095B3E24".ToLower(), pubkey, "pubkey");

            //ToDo: 2 – Perform SHA-256 hash on public key
            var sha256_pubkey = "";
            Check("1C72D90868DBCD0252A54EFFB25FB535B4C89B67D57B75FD88465C5F173DCAB5".ToLower(), sha256_pubkey, "sha256(pubkey)");

            //ToDo: 3 – Perform RIPEMD-160 hash from previous result
            var pubkeyhash = "";
            Check("EC00B99365A09B6E26C732378CD0C6257F7012BC".ToLower(), pubkeyhash, "ripemd160(sha256(pubkey))");

            //ToDo: 4 – Append first version byte from address-pubkeyhash-version (00AFEA21) to start and insert each subsequent byte after every floor(20/len(address-pubkeyhash-version)) bytes of prev.
            var addressPubkeyHashVersion = "00AFEA21";
            var vpubkeyhash = "";
            Check("00EC00B99365AFA09B6E26C7EA32378CD0C621257F7012BC".ToLower(), vpubkeyhash, "ver+pubkeyhash");

            //ToDo: 5 – Perform SHA-256 hash on previous result
            var sha256_vpubkeyhash = "";
            Check("EB04567F3EAA7DF652AEF6CF00F37BFBDE4C4848C257ADF6EE5CE3EA16B8FCAD".ToLower(), sha256_vpubkeyhash, "sha256(ver+pubkeyhash)");

            //ToDo: 6 - Perform SHA-256 hash again on previous result
            var sha256_sha256_vpubkeyhash = "";
            Check("9087E7F4C7A298F66B68954C85A0DFEA3B939AC8604B22424F95C446E763DF73".ToLower(), sha256_sha256_vpubkeyhash, "sha256(sha256(ver+pubkeyhash)");

            //ToDo: 7 – Take the first 4 bytes of previous result. This is the address checksum and XOR with address-checksum - value(953ABC69)
            var AddressChecksumValue = "953ABC69";
            var checksum = "";
            Check("05BD5B9D".ToLower(), checksum, "checksum");

            //ToDo: 8 - Add the 4 checksum bytes from stage 7 to end of output from stage 4.
            var hex = "";
            Check("00EC00B99365AFA09B6E26C7EA32378CD0C621257F7012BC05BD5B9D".ToLower(), hex, "hex address");

            //ToDo: 9 - Convert the result into a base58 string using Base58Check encoding.
            var address = "";
            Check("1Yu2BuptuZSiBWfr2Qy4aic6qEVnwPWrdkHPEc", address, "base58check address");

            Console.WriteLine("Done!");
            Console.ReadLine();

            //ToDo: Part II - Refer to http://www.multichain.com/developers/address-key-format/ convert a private key into WiF format using the instructions.
        }
    }
}
