// See https://aka.ms/new-console-template for more information


using System.Text;

string source = "Ana are mere, pere, prune, si alune.";

string word = "re";
int wordCount = 0;

int foundIndex = 0;
int searchIndex = 0;

while (foundIndex != -1)
{
    foundIndex = source.IndexOf(word, searchIndex);
    searchIndex = foundIndex + word.Length;
    if (foundIndex == -1)
    { 
        wordCount++;
    }
}

Console.WriteLine("Cuvantul cheie '" + word + "' apare de " + wordCount + " ori.");

Console.Write("Insert values for a, b and c: ");
string userInput = Console.ReadLine();
string[] values = userInput.Split(' ');

Console.WriteLine("\nUser inserted values:");
foreach (string value in values)
{
    Console.WriteLine("\t" + value);
}

StringBuilder builder = new StringBuilder();

builder.Append("Ana are mere.");
var insertPosition = builder.ToString().IndexOf(".");
builder.Insert(insertPosition, " ,pere");
builder.Insert(insertPosition, " ,prune");
Console.WriteLine(builder.ToString());

var name = "Popescu";
var age = 21;
var height = 1.72;
var heightInCM = height * 100;
var message = $"Profile: {name,7} age {age,2} height {heightInCM,3}[cm]";

Console.WriteLine(message);

name = "Ana";
age = 3;
height = 80;

Console.WriteLine($"Profile: {name,7} age {age,2} height {height,3}[cm]");

