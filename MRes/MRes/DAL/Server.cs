using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MRes.DAL
{
    class Server
    {
        private static Server instance;

        public static Server Instance
        {
            get
            {
                if (instance == null)
                    instance = new Server();
                return instance;

            }
            set => instance = value;
        }
        public const int BUFFER_SIZE = 1024;
        public const int PORT_NUMBER = 9999;
        public static IPEndPoint IP;
        public static IPAddress address;
        public static byte[] data;
        public static Stream stream;
        public static Socket server;
        public static List<Socket> ClientList;
        public static ASCIIEncoding encoding = new ASCIIEncoding();
        private static TcpClient client;

        public void Connect()
        {
            ClientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            Console.WriteLine("Server started on " + IP.Address);
            Console.WriteLine("Waiting for a connection...");

        }

       

    }
}
