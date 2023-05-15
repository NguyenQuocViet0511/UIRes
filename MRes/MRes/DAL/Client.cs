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
    class Client
    {
        private static Client instance;

        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;

            }
            set => instance = value;
        }
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 9999;
        static TcpListener listener;
        static IPAddress address;
        static byte[] data;
        static Stream stream;
        static Socket socket;
        static ASCIIEncoding encoding = new ASCIIEncoding();
        private static TcpClient client;

        public static void Connect()
        {
            client = new TcpClient();
            try
            {
                client.Connect("127.0.0.1", PORT_NUMBER);
                stream = client.GetStream();


            }
            catch (Exception)
            {

                Console.WriteLine("Không thể kết nối");
                return;

            }
            Thread Listen = new Thread(receive);
            Listen.IsBackground = true;
            Listen.Start();
        }
        public static void send(string Text)
        {
            data = encoding.GetBytes(Text);
            stream.Write(data, 0, data.Length);

        }
        static void receive()
        {
            try
            {
                while (true)
                {
                    data = new byte[BUFFER_SIZE];
                    stream.Read(data, 0, BUFFER_SIZE);
                    string str = (encoding.GetString(data));
                    Const.LISTEN = str;

                }

            }
            catch (Exception)
            {

                close();
            }

        }
        public static string Text(string text)
        {
            return text;
        }
        public static void close()
        {
            client.Close();
        }



    }
}
