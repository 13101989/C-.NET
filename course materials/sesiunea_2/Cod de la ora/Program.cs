// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte secole = 12;
ushort ani = 12345;
uint days = 123456789;
ulong hours = 123456789023456789;

Console.WriteLine("{0} secole is {1} ani, or {2} days, or {3} hours", secole, ani, days, hours);

double a = 0.66F;
double b = 0.34F;

double rezultat = 1 - (a + b);

if (rezultat < 0.000001 )
{
    Console.WriteLine("a+b == 1");
} 
else
{
    Console.WriteLine("a+b != 1");
}