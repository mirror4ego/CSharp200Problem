using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Project127
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoServer server = new EchoServer();
            server.Echo();
        }
    }

    public class EchoServer
    {
        public const int PORT = 5555;

        public void Echo()
        {
            TcpListener listener = null;
            NetworkStream ns = null;
            StreamReader sr = null;
            StreamWriter sw = null;
            TcpClient client = null;
            bool isEnd = false;
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                Console.WriteLine(ipAddress);

                // 1) 서버 소켓을 준비하고 실행한다.
                listener = new TcpListener(ipAddress, PORT);
                listener.Start();
                Console.WriteLine("server 1 ~~ Ready");
                // 클라이언트의 소켓에서 언제 붙을지 모르므로 계속 기다린다.
                while (!isEnd)
                {
                    Console.WriteLine("while 2 ~~ Ready");
                    // 클라이언트에서 연결이 끊어지면 끝낸다.
                    // 2) 서버에 붙은 클라이언트와 통신할 소켓 준비
                    client = listener.AcceptTcpClient();
                    Console.WriteLine("while 3 ~~ Accept");
                    // 3) 소켓이 있는 메시지를 이동시킬 통로 준비
                    ns = client.GetStream();
                    sr = new StreamReader(ns, Encoding.Default);
                    sw = new StreamWriter(ns, Encoding.Default);
                    Console.WriteLine("while~~Recieve Ready");
                    while (true)
                    {
                        String message = sr.ReadLine();

                        sw.WriteLine("[server: {0}]", message);
                        sw.Flush();
                    }//inner while
                }//outer while

            }
            catch (Exception ee)
            {
                System.Console.WriteLine(ee.Message);
            }
            finally
            {
                // 5) 사용이 끝나면 연결을 끊는다.
                if (sr != null) sr.Close();
                if (sw != null) sw.Close();
                if (client != null) client.Close();
                listener.Stop();// 서버 소켓을 닫는다.
            }
        }
    }
}
