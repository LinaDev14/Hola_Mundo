using System.Security.AccessControl;
// See https://aka.ms/new-console-template for more information

using System;
using System.Net;
using Newtonsoft.Json;


namespace getrequest
{

      namespace Client
      {
            public class Program
            {
                  public static async Task Main(string[] args)
                  {

                        string API_URL = "https://jsonplaceholder.typicode.com/posts?_limit=10";

                        var client = new WebClient();

                        var json = client.DownloadString(API_URL);

                        //Console.WriteLine(json);

                        // deserialize json
                        dynamic posts = JsonConvert.DeserializeObject(json);
                        


                  }
            }

      }
}