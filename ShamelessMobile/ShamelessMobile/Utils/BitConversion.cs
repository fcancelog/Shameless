using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamelessMobile.Utils
{
    public static class BitConversion
    {
        public static byte[] HextToByte(string hex)
        {
            var result =
                Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();

            return result;
        }

        public static string BytesToHex(IEnumerable<byte> bytes)
        {
            return BitConverter.ToString(bytes.ToArray()).Replace("-", string.Empty);
        }
    }
}
