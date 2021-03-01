using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public class MultiThreadedServer
    {
		private static void ProcessClientRequests(object argument)
		{
			TcpClient client = (TcpClient)argument;
			try
			{
				StreamReader reader = new StreamReader(client.GetStream());
				StreamWriter writer = new StreamWriter(client.GetStream());
				string s = String.Empty;
				string ip = client.Client.RemoteEndPoint.ToString();
				DateTime a = new DateTime();
				a = DateTime.Now;
				

				while (!(s = reader.ReadLine()).Equals("Exit") || (s == null))
				{
					if(s.Equals("a"))
                    {
						writer.WriteLine("From server -> b");
						Console.WriteLine("Client IP :{0} Message -> {1}",client.Client.RemoteEndPoint,s);
						StreamWriter SW = File.AppendText("\\log\\log.txt"); 
						SW.WriteLine("Client IP-> " + ip +" "+ "Message -> " +s+" " + "DateTime -> " +a.ToString());
						SW.Close();
					}
					else if(s.Equals("b"))
                    {
						writer.WriteLine("From Server-> c");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
						StreamWriter SW = File.AppendText("\\log\\log.txt");
						SW.WriteLine("Client IP-> " + ip + " " + "Message -> " + s + " " + "DateTime -> " + a.ToString());
						SW.Close();

					}
					else if (s.Equals("c"))
					{
						writer.WriteLine("From Server-> d");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
						StreamWriter SW = File.AppendText("\\log\\log.txt");
						SW.WriteLine("Client IP-> " + ip + " " + "Message -> " + s + " " + "DateTime -> " + a.ToString());
						SW.Close();
					}
					else if (s.Equals("d"))
					{
						writer.WriteLine("From Server-> e");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
						StreamWriter SW = File.AppendText("\\log\\log.txt");
						SW.WriteLine("Client IP-> " + ip + " " + "Message -> " + s + " " + "DateTime -> " + a.ToString());
						SW.Close();
					}
					else
                    {
						writer.WriteLine("From Server -> Error message please just write'a,b,c,d' ");
						Console.WriteLine("Client IP :{0} Message -> {1}", ip, s);
						StreamWriter SW = File.AppendText("\\log\\log.txt");
						SW.WriteLine("Client IP-> " + ip + " " + "Message -> " + s + " " + "DateTime -> " + a.ToString());
						SW.Close();
					}


					writer.Flush();
				}
				reader.Close();
				writer.Close();
				client.Close();
				Console.WriteLine("Closing client connection.");
			}
			catch (IOException)
			{
				Console.WriteLine("Existing thread.");
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
				listener = new TcpListener(IPAddress.Any, 8080);
				listener.Start();
				Console.WriteLine("Server is started");
				while (true)
				{
					Console.WriteLine("Waiting for client connection");
					TcpClient client = listener.AcceptTcpClient();
					Console.WriteLine("{0} is connected",client.Client.RemoteEndPoint);
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
