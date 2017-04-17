using System;
using System.IO;
using System.Linq;

namespace Class.Util.h2b
{
    class Program
    {
        /// <summary>
        /// Convert hexadecimal binary encoding to bytes
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] Hex2Bytes(string hex)
        {
            var s = hex.ToLower();
            if (s.Length % 2 != 0)
                throw new Exception("Hexadecimal length should be even.");
            var bytes = Enumerable.Range(0, s.Length)
                            .Where(x => x % 2 == 0)
                            .Select(x => Convert.ToByte(s.Substring(x, 2), 16))
                            .ToArray();
            return bytes;
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: h2b hex-filepath bin-filepath");
                return;
            }
            try
            {
                string hex = args[0];
                string bin = args[1];
                var bytes = Hex2Bytes(File.ReadAllText(hex));
                File.WriteAllBytes(bin, bytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
