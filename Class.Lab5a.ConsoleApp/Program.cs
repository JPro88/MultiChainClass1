using Class.MultichainLib;
using System;

namespace Class.Lab5a.ConsoleApp
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

            //ToDo: 0 - Start with a private ECDSA key (retrieve it from the link)
            string privateKey = "";

            //ToDo: 1 – Generate public key
            var pubkey = "";
            Check("0450863AD64A87AE8A2FE83C1AF1A8403CB53F53E486D8511DAD8A04887E5B23522CD470243453A299FA9E77237716103ABC11A1DF38855ED6F2EE187E9C582BA6".ToLower(), pubkey, "pubkey");

            //ToDo: 2 – Perform SHA-256 hash on public key
            var sha256_pubkey = "";
            Check("600FFE422B4E00731A59557A5CCA46CC183944191006324A447BDB2D98D4B408".ToLower(), sha256_pubkey, "sha256(pubkey)");

            //ToDo: 3 – Perform RIPEMD-160 hash from previous result
            var pubkeyhash = "";
            Check("010966776006953D5567439E5E39F86A0D273BEE".ToLower(), pubkeyhash, "ripemd160(sha256(pubkey))");

            //ToDo: 4 – Append version byte (0x00 for Main Network) in front of previous result
            var vpubkeyhash = "";
            Check("00010966776006953D5567439E5E39F86A0D273BEE".ToLower(), vpubkeyhash, "ver+pubkeyhash");

            //ToDo: 5 – Perform SHA-256 hash on previous result
            var sha256_vpubkeyhash = "";
            Check("445C7A8007A93D8733188288BB320A8FE2DEBD2AE1B47F0F50BC10BAE845C094".ToLower(), sha256_vpubkeyhash, "sha256(ver+pubkeyhash)");

            //ToDo: 6 - Perform SHA-256 hash again on previous result
            var sha256_sha256_vpubkeyhash = "";
            Check("D61967F63C7DD183914A4AE452C9F6AD5D462CE3D277798075B107615C1A8A30".ToLower(), sha256_sha256_vpubkeyhash, "sha256(sha256(ver+pubkeyhash)");

            //ToDo: 7 - Take the first 4 bytes of previous result. This is the address checksum
            var checksum = sha256_sha256_vpubkeyhash.Substring(0, 8);
            Check("D61967F6".ToLower(), checksum, "checksum");

            //ToDo: 8 - Add the 4 checksum bytes from stage 7 to end of output from stage 4.
            var hex = vpubkeyhash + checksum;
            Check("00010966776006953D5567439E5E39F86A0D273BEED61967F6".ToLower(), hex, "hex address");

            //ToDo: 9 - Convert the result into a base58 string using Base58Check encoding.
            var address = "";
            Check("16UwLL9Risc3QfPqBUvKofHmBQ7wMtjvM", address, "base58check address");

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
