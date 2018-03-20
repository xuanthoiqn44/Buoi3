using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Buoi3
{
    class Program
    {
        public static int Comparetonumber(string s1)
        {
            int so = 0;
            switch(s1)
            {
                case "Kéo":
                    so = 1;
                    break;
                case "Bao":
                    so = 2;
                    break;
                case "Búa":
                    so = 3;
                    break;
            }
            return so;
        }
        //n1 server n2 client
        public static string compare(int n1, int n2)
        {
            string result = "";
            if(n1 == 1 && n2 == 2)
            {
                result = "Thua";
            }
            else if(n1 == 1 && n2 == 3)
            {
                result = "Thắng";
            }
            else if(n1 == 2 && n2 == 1)
            {
                result = "Thắng";
            }
            else if(n1 == 2 && n2 == 3)
            {
                result = "Thua";
            }
            else if(n1 == 3 && n2 == 1)
            {
                result = "Thua";
            }
            else if(n1 == 3 && n2 == 2)
            {
                result = "Thắng";
            }
            else
            {
                result = "Hòa";
            }
            return result;
        }
        public static int Random()
        {
            string result = "";
            Random rand = new Random();
            int output = rand.Next(1, 4);
            return output;
        }
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9090);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);
            while (true)
            {
                
                data = new byte[1024];
                recv = newsock.ReceiveFrom(data, ref Remote);
                int random = Random();
                Console.WriteLine(random);
                string input = Encoding.UTF8.GetString(data, 0, recv);
                Console.WriteLine(input);
                int so = Comparetonumber(input);
                string output = compare(random, so);
                data = Encoding.UTF8.GetBytes(output);
                newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
            }
        }
    }
}
