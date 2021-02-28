using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class MultiThreadedEchoServer
    {
		private static void ProcessClientRequests(object argument)
		{
			TcpClient client = (TcpClient)argument;
			try
			{
				StreamReader reader = new StreamReader(client.GetStream());
				StreamWriter writer = new StreamWriter(client.GetStream());
				string s = String.Empty;
				string ip = "127.0.0.1";

				while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
				{
					if(s.Equals("a"))
                    {
						writer.WriteLine("From server -> b");
						Console.WriteLine("Client IP :{0} Message -> {1}",ip,s);
					}
					else if(s.Equals("b"))
                    {
						writer.WriteLine("From Server-> c");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
					}
					else if (s.Equals("c"))
					{
						writer.WriteLine("From Server-> d");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
					}
					else if (s.Equals("d"))
					{
						writer.WriteLine("From Server-> e");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
					}
					else
                    {
						writer.WriteLine("From Server -> Error message please just write'a,b,c,d' ");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
					}


					writer.Flush();
				}
				reader.Close();
				writer.Close();
				client.Close();
				Console.WriteLine("Closing client connection!");
			}
			catch (IOException)
			{
				Console.WriteLine("Problem with client communication. Exiting thread.");
			}
			finally
			{
				if (client != null)
				{
					client.Close();
				}
			}
		}
		static void Main(string[] args)
        {
			TcpListener listener = null;
			try
			{
				listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
				listener.Start();
				Console.WriteLine("MultiThreadedEchoServer started...");
				while (true)
				{
					Console.WriteLine("Waiting for incoming client connections...");
					TcpClient client = listener.AcceptTcpClient();
					Console.WriteLine("Accepted new client connection...");
					Thread t = new Thread(ProcessClientRequests);
					t.Start(client);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				if (listener != null)
				{
					listener.Stop();
				}
			}
		}
    }
}
