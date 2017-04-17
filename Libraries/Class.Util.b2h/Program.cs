using System;
using System.IO;

namespace Class.Util.b2h
{
    class Program
    {
        /// <summary>
        /// Convert bytes to hexadecimal binary encoding
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string Bytes2Hex(byte[] bytes)
        {
            if (bytes != null)
                return BitConverter.ToString(bytes).ToLower().Replace("-", "");
            return null;
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: b2h bin-filepath hex-filepath");
                return;
            }

            try
            {
                var bin = args[0];
                var hex = args[1];
                byte[] bytes = File.ReadAllBytes(bin);
                File.WriteAllText(hex,Bytes2Hex(bytes));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
    }
}
