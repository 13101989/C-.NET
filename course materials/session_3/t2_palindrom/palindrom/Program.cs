using System.Text.RegularExpressions;

string sentenceIntroduced = "";
string sentenceCleaned = "";
int i;
int continueScript = 1;

Console.WriteLine("Please insert the sentence/string to check if it's a palindrom:");
sentenceIntroduced = Console.ReadLine();
sentenceCleaned = Regex.Replace(sentenceIntroduced, "[^A-Za-z]", "");

if (sentenceIntroduced == "" || sentenceCleaned == "" || sentenceIntroduced == " " || sentenceCleaned == " ")
{
    continueScript = 0;
    Console.WriteLine($"\nExited because {sentenceIntroduced} is not a valid string/sentence");
}

if (sentenceCleaned == sentenceIntroduced && continueScript==1)
{
    Console.WriteLine($"\nSentence/string to check is: {sentenceIntroduced}");

    for (i = 0; i <= sentenceIntroduced.Length / 2; i++)
    {
        if (sentenceIntroduced[i] != sentenceIntroduced[sentenceIntroduced.Length - i - 1])
        {
            Console.WriteLine($"\n{sentenceIntroduced} is not a palindrom");
            break;
        }
    }

    if (i == (sentenceIntroduced.Length / 2) + 1)
    {
        Console.WriteLine($"\n{sentenceIntroduced} is a palindrom");
    }
}
else if (continueScript == 1)
{
    Console.WriteLine($"\nCleaned (without numbers and non-alphanumeric characters) sentence/string to check is: {sentenceCleaned}");

    for (i = 0; i <= sentenceCleaned.Length / 2; i++)
    {
        if (sentenceCleaned[i] != sentenceCleaned[sentenceCleaned.Length - i - 1])
        {
            Console.WriteLine($"\n{sentenceCleaned} is not a palindrom");
            break;
        }
    }

    if (i == (sentenceCleaned.Length / 2) + 1)
    {
        Console.WriteLine($"\n{sentenceCleaned} is a palindrom");
    }
}






