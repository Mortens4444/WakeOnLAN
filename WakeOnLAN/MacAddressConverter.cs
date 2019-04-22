using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WakeOnLAN
{
    public static class MacAddressConverter
    {
        public const int MacAddressLengthInBytes = 6;

        public static byte[] StringToByteArray(string macString)
        {
            if (String.IsNullOrEmpty(macString))
            {
                throw new Exception("Please fill the MAC address");
            }
            var mac = Regex.Replace(macString, "[^0-9A-Fa-f]", String.Empty);
            if (mac.Length != MacAddressLengthInBytes * 2)
            {
                throw new Exception($"Incorrect MAC address: {macString}{Environment.NewLine}MAC address format is: 01-23-45-67-89-AB or 01:23:45:67:89:AB");
            }

            var result = new byte[MacAddressLengthInBytes];
            for (var i = 0; i < result.Length; i++)
            {
                var hexa = new string(new[] { mac[i * 2], mac[i * 2 + 1] });
                result[i] = Byte.Parse(hexa, NumberStyles.HexNumber);
            }
            return result;
        }
    }
}
