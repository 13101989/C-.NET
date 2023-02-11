// See https://aka.ms/new-console-template for more information

int[] a = { 10, 99, -3, 22, 14 };

for (int index = 0; index < a.Length; index++)
{
    Console.WriteLine("a[{0}] = {1}", index, a[index]);
}


foreach (int element in a)
{
    Console.WriteLine(element);
}


int elementCautat = -3;
for (int index = 0; index < a.Length; index++)
{
    Console.WriteLine("Iteratia numarul " + (index + 1));
    if (a[index] == elementCautat)
    {
        Console.WriteLine("Elementul cu valoarea " + a[index] + " se afla la pozitia " + index);
        break;
    }
}


for (int index = a.Length - 1; index >= 0; index--)
{
    Console.WriteLine("a[{0}] = {1}", index, a[index]);
}


int[] b = new int[a.Length + 1];

int x = 0;
foreach (int value in a)
{
    b[x] = value;
    x++;
}
b[b.Length - 1] = 99;

Console.Write("b = ");
foreach (int element in b)
{
    Console.Write(element + " ");
}


int[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 }
};

data[1, 1] = 99;

for (int row = 0; row < data.GetLength(0); row++)
{
    for (int column = 0; column < data.GetLength(1); column++)
    {
        Console.WriteLine("data[ " + row + " , " + column + " ] = " + data[row, column]);
    }
}


int?[][] jaggedData = new int?[3][];

jaggedData[0] = new int?[] { 1, 2, 3 };
jaggedData[1] = new int?[] { null, 4 };
jaggedData[2] = new int?[] { 5, 6 };

Console.WriteLine(jaggedData.Length);
Console.WriteLine(jaggedData[1].Length);

jaggedData[1][0] = 33;

for (int row = 0; row < jaggedData.Length; row++)
{
    for (int col = 0; col < jaggedData[row].Length; col++)
    {
        Console.WriteLine("jaggedData[" + row + "][" + col + "] = " + jaggedData[row][col]);
    }
}


string s1 = null;
string s2 = "";
bool areEqual = s1 == s2;

string[] users = { "Ionel", "Popescu", "clara", "Ana" };

Console.WriteLine(users[0]);
Console.WriteLine(users[0][0]);

int result = string.Compare(users[0], "ionel", false);
Console.WriteLine(result);
Console.WriteLine(users[0][0] > 'i');

string toFind = "Clara";
foreach (string user in users)
{
    if (user.Equals(toFind, StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(user + " was found.");
        break;
    }
}


