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

if (rezultat < 0.000001)
{
    Console.WriteLine("a+b == 1");
}
else
{
    Console.WriteLine("a+b != 1");
}


char symbol = 'A';
//Console.WriteLine("1. Char {0}", symbol);
Console.WriteLine("1. Char " + symbol);

symbol = '\x0041';
Console.WriteLine("2. Char {0}", symbol);

symbol = (char)65;
Console.WriteLine("3. Char {0}", symbol);

symbol = '\u0041';
Console.WriteLine("4. Char {0}", symbol);


string first = "\tana \n";
string second = "are\" mere";
string mesaj = first + second;
Console.WriteLine(mesaj);

int primulNumar = 5;
int maxim = primulNumar;

int minim = new int();

if (a > 0)
    minim = 0;
else
    minim = 1;

Console.WriteLine("{0}", minim);


Console.WriteLine("\"\" ? null => {0}", "" == null);

double realNumber = 12.5F;

double maxAmmount = 1.23E+3;
mesaj = "rezultat = " + maxAmmount;
Console.WriteLine(mesaj);


var lista = @"ana are
    mere
    pere
    prune
";

Console.WriteLine(lista);

string greutate = "15";
int rez = 0;



int? temperatura = null;


var numarElemente = 5;
var numeUtilizator = "Ana";


ushort scurt = 12345;
uint lung = 11223;

scurt = (ushort)lung;
Console.WriteLine("scurt = " + scurt);


string userData = Console.ReadLine();

bool isValid = Int32.TryParse(greutate, out rez);
if (isValid)
{
    Console.WriteLine("The value of the input is " + rez);
}
else
{
    Console.WriteLine("Value \'{0}\' could not be converted", greutate);
}

Console.WriteLine("Utilizatorul a introdus: " + userData);
