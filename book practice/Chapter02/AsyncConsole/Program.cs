using System.Diagnostics;
using static System.Console;

namespace AsyncConsole
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
            WriteLine("Apple's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);
        }
    }
}