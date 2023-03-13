using System.Diagnostics;
using static System.Console;


internal class Program
{
    static async void Main(string[] args)
    {
        /* Visual Studio: run the app, change the message, click Hot Reload button.
            * Visual Studio Code: run the app using dotnet watch, change the message. */
        while (true)
        {
            WriteLine("Hello, Hot Reload!");
            await Task.Delay(2000);
        }
    }
}
