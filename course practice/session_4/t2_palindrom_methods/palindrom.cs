using System.Text.RegularExpressions;

public class CheckIfPalindrom
{
    static void Main()
    {
        var userInput = GetUserInput();
        if (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine($"\nExited because '{userInput}' is not a valid string/sentence");
            return;
        }
        Console.WriteLine($"\nCleaned string to check is: {userInput}");

        if (IsPalindrom(userInput))
        {
            Console.WriteLine($"\n{userInput} is a palindrom");
        }
        else
        {
            Console.WriteLine($"\n{userInput} is not a palindrom");
        }
    }

    static string GetUserInput()
    {
        Console.WriteLine("Please insert the sentence/string to check if it's a palindrom:");

        string? sentenceIntroduced = Console.ReadLine();
        if (string.IsNullOrEmpty(sentenceIntroduced))
        {
            return string.Empty;
        }

        string sentenceCleaned = Regex.Replace(sentenceIntroduced, "[^A-Za-z]", "");
        if (string.IsNullOrEmpty(sentenceCleaned))
        {
            return string.Empty;
        }
        return sentenceCleaned;
    }

    static bool IsPalindrom(string input)
    {
        int i;

        for (i = 0; i <= input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}



