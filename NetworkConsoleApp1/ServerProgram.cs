// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class ServerProgram
{

    static void Main()
    {

    TcpListener server = null;
        try
        {
            int port = 5000; // Server will listen on this port
            server = new TcpListener(IPAddress.Any, port); // Accept connections from any IP
            server.Start(); // Start listening

            Console.WriteLine("Server started. Waiting for a client...");

            TcpClient client = server.AcceptTcpClient(); // Block until a client connects
            Console.WriteLine("Client connected!");

            NetworkStream stream = client.GetStream(); // Get stream for data exchange

            string response = string.Empty;
            while (response != "STOP")
            {
                // 1. Read incoming message from client
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received from client: " + message);

                // 2. Send a response back to client
                //string response = "Hello from server!";
                Console.Write("Message to client: ");
                response = Console.ReadLine();
                byte[] responseBytes = Encoding.ASCII.GetBytes(response);
                stream.Write(responseBytes, 0, responseBytes.Length);
                Console.WriteLine("Sent to client: " + response);

            }

            client.Close(); // Close client connection
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            server?.Stop(); // Stop the server if running
        }
    }
}

