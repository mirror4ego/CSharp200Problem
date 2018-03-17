﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace Project124
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoClient client = new EchoClient();
            client.Echo();
        }
    }

    public class EchoClient
    {
        public const int PORT = 5555;
        public const string IP = "127.0.0.1";

        public void Echo()
        {
            NetworkStream ns = null;
            StreamWriter sw = null;
            TcpClient client = null;

            try
            {
                // 1) 클라이언트 소켓을 준비한다.

                
                client = new TcpClient(IP, PORT); // 소켓
                
                Console.WriteLine("client~~서버에 접속");
                // 2) 소켓에 있는 메시지를 이동시킬 통로 준비
                ns = client.GetStream();
                sw = new StreamWriter(ns, Encoding.Default);
                string ss = string.Empty;
                //ctrl+c
                Console.WriteLine("입력하세요");
                // 3) 키보드로 메시지 읽기
                while ((ss = Console.ReadLine()) != null)
                {
                    // 4) 서버로 메시지 보내기(소켓에 메시지 달기)
                    sw.WriteLine(ss); // 서버로 보내기
                    sw.Flush();
                }
            }catch(Exception ee)
            {
                System.Console.WriteLine(ee.Message);
            }
            finally
            {
                // 5) 사용 후 닫기
                sw.Close();
                client.Close();
            }
        }
    }
}
