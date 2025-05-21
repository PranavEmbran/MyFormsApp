// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data;
using System.Data.SQLite;


class ServerProgram
{
    private const string DbFileName = "infodb.db";
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
                string[] info = new string[4];
                string infostring = string.Empty;

                // 1. Read incoming message from client
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                infostring = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received from client: " + infostring);
                Console.WriteLine($"Send to server: {info[0]} {info[1]} {info[2]} {info[3]}" + infostring);

                info = infostring.Split(" ");
                SaveToDatabase(info[0], info[1], info[2], info[3]);

                // 2. Send a response back to client
                //string response = "Hello from server!";

                //Console.Write("Message to client: ");
                //response = Console.ReadLine();
                response = "STOP";
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


    //private void SaveToDatabase(
    private static void SaveToDatabase(
            string name,
            string id,
            string email,
            string phone
            )
    {
        // Build connection string (file is auto-created)
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DbFileName);
        var connString = new SQLiteConnectionStringBuilder
        {
            DataSource = dbPath,
            Version = 3
        }.ToString();

        using (var conn = new SQLiteConnection(connString))
        {
            conn.Open();

            // 1) Create table if missing
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                      CREATE TABLE IF NOT EXISTS Registrations (
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId  TEXT    NOT NULL UNIQUE,  -- corresponds to `string id`
    Name       TEXT    NOT NULL,
    DOB        TEXT    NOT NULL DEFAULT '1900-01-01',
    Email      TEXT    NOT NULL UNIQUE,
    Phone      TEXT    NOT NULL,
    Gender     TEXT,
    Pwd        INTEGER NOT NULL,         -- corresponds to `int pwd`
    CSharp     REAL    NOT NULL,         -- corresponds to `decimal cSharp`
    Java       REAL    NOT NULL,         -- corresponds to `decimal java`
    Php        REAL    NOT NULL,         -- corresponds to `decimal php`
    Cgpa       REAL    NOT NULL,         -- corresponds to `decimal cgpa`
    CreatedAt  TEXT    NOT NULL
);
";
                cmd.ExecuteNonQuery();
            }

            // 2) Insert the record
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
    INSERT INTO Registrations
        (StudentId, Name, DOB, Email, Phone, Gender, Pwd, CSharp, Java, Php, Cgpa, CreatedAt)
    VALUES
        (@studentId, @name, @dob, @email, @phone, @gender, @pwd, @CSharp, @Java, @Php, @Cgpa, @createdAt);";


                //            cmd.CommandText = @"
                //INSERT INTO Registrations
                //    (StudentId, Name, Email, Phone, CreatedAt, dob)
                //VALUES
                //    (@studentId, @name, @email, @phone, @createdAt, '1900-01-01');";

                //            cmd.CommandText = @"
                //INSERT INTO Registrations
                //    (StudentId, Name, DOB, Email, Phone, Gender, Pwd, CSharp, Java, Php, Cgpa, CreatedAt)
                //VALUES
                //    (@studentId, @name, 0, @email, @phone, 0, 0, 0, 0, 0, 0, @createdAt);";

                //                cmd.CommandText = @"
                //INSERT INTO Registrations
                //    (StudentId, Name, DOB, Email, Phone, Gender, Pwd, CSharp, Java, Php, Cgpa, CreatedAt)
                //VALUES
                //    (@studentId, @name, '1900-01-01', @email, @phone, 'Not Specified', 0, 0.0, 0.0, 0.0, 0.0, @createdAt);";




                cmd.Parameters.AddWithValue("@studentId", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", "1900-01-01");
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", "Not Specified");
                cmd.Parameters.AddWithValue("@pwd", 0);
                cmd.Parameters.AddWithValue("@CSharp", 0.0);
                cmd.Parameters.AddWithValue("@Java", 0.0);
                cmd.Parameters.AddWithValue("@Php", 0.0);
                cmd.Parameters.AddWithValue("@Cgpa", 0.0);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.UtcNow.ToString("o"));



                //cmd.ExecuteNonQuery();
                Console.WriteLine("DB Path: " + dbPath);


                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Insert failed: " + ex.Message);
                }

                foreach (SQLiteParameter p in cmd.Parameters)
                {
                    Console.WriteLine($"[{p.ParameterName}] = {p.Value}");
                }

            }



        }


    }

}


