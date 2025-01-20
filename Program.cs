namespace ServidorUDP
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress broadcast = IPAddress.Parse("192.168.170.113");

            byte[] sendbuf = Encoding.ASCII.GetBytes(args[0]);
            IPEndPoint ep = new IPEndPoint(broadcast, 11000);

            s.SendTo(sendbuf, ep);

            Console.WriteLine("AQUI ESTA EL CONFLICTO");
        }
    }
}
