using System.Net;
using System.Net.Sockets;

namespace WakeOnLAN
{
    public static class WakeOnLan
    {
        public static void SendMagicPacket(string macAddress, ushort port = 7)
        {
            var endPoint = new IPEndPoint(IPAddress.Broadcast, port);
            using (var clientSocket = new Socket(endPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp))
            {
                clientSocket.Connect(endPoint);
                var macByteArray = MacAddressConverter.StringToByteArray(macAddress);
                var magicPacket = MagicPacketForger.Forge(macByteArray);
                clientSocket.Send(magicPacket, 0, magicPacket.Length, SocketFlags.None);
            }
        }
    }
}
