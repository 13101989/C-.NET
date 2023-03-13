using CallStackExceptionHandlingLib;
using System.Diagnostics;
using static System.Console;
WriteLine("In Main");
Alpha();
void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}
void Beta()
{
    WriteLine("In Beta");
    try
    {
        Calculator.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");

        // throw the caught exception as if it happened here
        // this will lose the original call stack
        //throw ex;

        // rethrow the caught exception and retain its original call stack
        throw;
    }
}
