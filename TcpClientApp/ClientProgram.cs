// See https://aka.ms/new-console-template for more information
using System;
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

            TcpClient client = new TcpClient(serverIp, port); // Connect to server
            Console.WriteLine("Connected to server!");

            NetworkStream stream = client.GetStream(); // Get stream for data exchange

            // 1. Send a message to the server
            string message = "Hello server!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Sent to server: " + message);

            // 2. Receive response from server
            byte[] buffer = new byte[256];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received from server: " + response);

            client.Close(); // Close connection
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

