using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information

using System;
using System.Net;
using Newtonsoft.Json;


namespace getrequest
{
      class using Greet;
      using Grpc.Net.Client;
      using System;
      using System.Threading.Tasks;
      
      namespace Client
      {
            public class Program
            {
                  public static async Task Main(string[] args)
                  {
                        try
                        {
                              using var channel = GrpcChannel.ForAddress("http://localhost:5000");
                              var client = new Greeter.GreeterClient(channel);
      
                              var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                              Console.WriteLine("Greeting: " + reply.Message);
                        }
                        catch (Exception ex)
                        {
                              Console.WriteLine($"ERROR: {ex.Message}");
                        }
      
                        Console.WriteLine("Shutting down");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                  }
            }
      }{}

}