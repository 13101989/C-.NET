//using System;

//class HelloCSharp
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello, C#");
//    }
//}


byte centuries = 12;  
ushort years = 12345;
ushort days = 65535;
ulong hours = 123456789023456789; 
Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuries, years, days, hours);

double a = 0.66F;
double b = 0.34F;
bool equal = (a + b == 1); // False!!!
Console.WriteLine($"a + b = {a + b} == 1, this is {equal}");


char symbol = 'A'; // character literal
Console.WriteLine("Character {0} as literal", symbol);

symbol = '\x0041'; // hexadecimal
Console.WriteLine("Character {0} as decimal", symbol);

symbol = (char)65; // cast from integer type
Console.WriteLine("Character {0} as integer type", symbol);

symbol = '\u0041'; // unicode
Console.WriteLine("Character {0} as unicode", symbol);


string first = "ana \n";
string second = "are \" mere";
string mesaj = first + second;
Console.WriteLine(mesaj);














