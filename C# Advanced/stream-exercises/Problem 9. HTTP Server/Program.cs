using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.HTTP_Server
{
    class Program
    {
        private const int PortNumber = 1337;

        static void Main()
        {
            var tcpListener = new TcpListener(IPAddress.Any, PortNumber);

            tcpListener.Start();
            Console.WriteLine("Listening on port {0}...", PortNumber);

            while (true)
            {
                using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    byte[] request = new byte[4096];

                    int readBytes = stream.Read(request, 0, 4096);

                    Console.WriteLine(Encoding.UTF8.GetString(request, 0, readBytes));

                    var reqData = Encoding.UTF8.GetString(request, 0, readBytes).Replace("\\", "/");

                    if (reqData.Split('/')[1] == "info HTTP")
                    {

                        byte[] htmlBytes =
                            Encoding.UTF8.GetBytes(
                                $"HTTP/1.1 200 OK\r\nDate: {DateTime.Now}\r\nServer: {Environment.MachineName}\r\nLast-Modified: Wed, 22 Jul 2009 19:15:56 GMT\r\nContent-Length: 88\r\nContent-Type: text/html\r\nConnection: Closed\r\n\r\n<html>\r\n<body>\r\n<h1>Current Time:{DateTime.Now} <br>Logical Processors Count: {Environment.ProcessorCount}</h1>\r\n</body>\r\n</html>");

                        stream.Write(htmlBytes, 0, htmlBytes.Length);
                    }

                    else if (reqData.Split('/')[1] == " HTTP")
                    {
                        byte[] htmlBytes =
                            Encoding.UTF8.GetBytes(
                                $"HTTP/1.1 200 OK\r\nDate: {DateTime.Now}\r\nServer: {Environment.MachineName}\r\nLast-Modified: Wed, 22 Jul 2009 19:15:56 GMT\r\nContent-Length: 188\r\nContent-Type: text/html\r\nConnection: Closed\r\n\r\n<html>\r\n<body>\r\n<h1>Hello, SoftUni! <a href='http://localhost:1337/info'>Info Page</a> </h1>\r\n</body>\r\n</html>");

                        stream.Write(htmlBytes, 0, htmlBytes.Length);

                    }

                    else
                    {
                        byte[] htmlBytes =
                            Encoding.UTF8.GetBytes(
                                $"HTTP/1.1 200 OK\r\nDate: {DateTime.Now}\r\nServer: Apache/2.2.14 (Win32)\r\nLast-Modified: Wed, 22 Jul 2009 19:15:56 GMT\r\nContent-Length: 88\r\nContent-Type: text/html\r\nConnection: Closed\r\n\r\n<html>\r\n<body>\r\n<h1>Error!!!</h1>\r\n</body>\r\n</html>");

                        stream.Write(htmlBytes, 0, htmlBytes.Length);

                    }

                }
            }
        }
    }
}
