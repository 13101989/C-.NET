using System.Diagnostics.Metrics;
using System.Text.RegularExpressions; //Regex


Regex defaultExpression = new(@"^\d+$");
ConsoleKeyInfo keyPressed;
bool loop = true;

WriteLine("The default regular expression checks for at least one digit.");

while (loop)
{
    WriteLine("Enter a regular expression (or press ENTER to use the default:");
    string expressionAsString = ReadLine()!;
    Regex regexExpression = new($@"{expressionAsString}");
    
    WriteLine("Enter some input:");
    string input = ReadLine()!;

    if (string.IsNullOrWhiteSpace(expressionAsString))
    {
        WriteLine($"{input} matches {defaultExpression} {defaultExpression.IsMatch(input)}");
    }
    else
    {
        WriteLine($"{input} matches {regexExpression} {regexExpression.IsMatch(input)}");
    }

    WriteLine("Press ESC to end or any key to try again.");

    keyPressed = Console.ReadKey();
    if (keyPressed.Key == ConsoleKey.Escape)
    {
        loop = false;
    }
}


