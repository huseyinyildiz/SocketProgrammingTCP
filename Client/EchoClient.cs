using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections;
namespace Client
{
    public class EchoClient
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8080);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                String ip = "127.0.0.1";
                
                while (!s.Equals("Exit"))
                {
                    Console.Write("Enter a string to send to the server: ");
                    s = Console.ReadLine();
                  
                    Console.WriteLine();
                    writer.WriteLine(s,ip);
                   
                    writer.Flush();
                    String server_string = reader.ReadLine();
                    Console.WriteLine(server_string);
                }
                reader.Close();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
