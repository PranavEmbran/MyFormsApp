// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ClientProgram
{
    static void Main()
    {
        try
        {
            string serverIp = "127.0.0.1"; // Localhost (same machine)
            int port = 5000;

            bool check = true;

            while (check)
            {
                Console.WriteLine("Connect with:\n1] Localhost (127.0.0.1)\n2] Remote Host\nEnter 1 or 2: ");
                int hostno = int.Parse(Console.ReadLine());

                if (hostno == 1)
                {
                    check = false;
                }
                if (hostno == 2)
                {
                    Console.Write("Enter Server IP address: ");
                    serverIp = Console.ReadLine();
                    if (IPAddress.TryParse(serverIp, out IPAddress? ip) && ip != null)
                    {
                        Console.WriteLine("Valid IP address: " + ip);
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid IP address.");
                    }
                }
            }
            TcpClient client = new TcpClient(serverIp, port); // Connect to server
            Console.WriteLine("Connected to server!");

            NetworkStream stream = client.GetStream(); // Get stream for data exchange

            string message = string.Empty;
            while (message != "STOP")
            {
                // 1. Send a message to the server
                //string message = "Hello server!";
                Console.WriteLine("Enter Name, ID, Email id and Phone number: ");
                //message = Console.ReadLine();

                string[] info = new string[4];
                Console.Write("Enter Name: ");
                info[0] = Console.ReadLine();
                Console.Write("Enter ID: ");
                info[1] = Console.ReadLine();
                Console.Write("Enter EmailID: ");
                info[2] = Console.ReadLine();
                Console.Write("Enter Phone no: ");
                info[3] = Console.ReadLine();

                message = "STOP";

                //Console.Write("Enter Name: ");
                //string name = Console.ReadLine();
                //Console.Write("Enter ID: ");
                //string id = Console.ReadLine();
                //Console.Write("Enter EmailID: ");
                //string email = Console.ReadLine();
                //Console.Write("Enter Phone no: ");
                //string mobile = Console.ReadLine();

                string sendInfo = string.Join(" ", info);
                byte[] data = Encoding.ASCII.GetBytes(sendInfo); 
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent to server: " + sendInfo);

                // 2. Receive response from server
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received from server: " + response);

            }
            client.Close(); // Close connection
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

