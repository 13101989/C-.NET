int lengthOfArray;
string numbers = "";
string stringInteger;
int testInteger;
int increment = 1;
int continueScript = 1;


Console.WriteLine("Please insert the number of integers for which you want to calculate the min and max (at least 2):");
string numberOfElements = Console.ReadLine();


if (int.TryParse(numberOfElements, out lengthOfArray) && lengthOfArray > 1)
{
    while (lengthOfArray > 0)
    {
        Console.WriteLine($"Please insert number {increment} out of {lengthOfArray + increment - 1}:");
        stringInteger = Console.ReadLine();
        numbers += stringInteger + " ";

        if (int.TryParse(stringInteger, out testInteger))
        {
            lengthOfArray--;
            increment++;
        }
        else
        {
            Console.WriteLine($"Exited beacause value {stringInteger} is not a valid integer.");
            continueScript = 0;
            break;
        }
    }
}
else
{
    Console.WriteLine($"Exited beacause value {numberOfElements} is not a valid integer  or is equal with 1.");
    continueScript = 0;
}



if (continueScript == 1)
{
    Console.WriteLine($"\nThe numbers you have introduced are: {numbers}");

    int.TryParse(numberOfElements, out lengthOfArray);
    string[] arrayOfStrings = numbers.Split(" ");
    int[] arrayOfIntegers = new int[lengthOfArray];


    for (int i = 0; i < lengthOfArray; i++)
    {
        int.TryParse(arrayOfStrings[i], out arrayOfIntegers[i]);
    }

    int Min = arrayOfIntegers[0];

    for (int i = 1; i < lengthOfArray; i++)
    {
        
        if (arrayOfIntegers[i] < Min)
        {
            Min = arrayOfIntegers[i];
        }
    }

    int Max = arrayOfIntegers[0];

    for (int i = 1; i < lengthOfArray; i++)
    {
        
        if (arrayOfIntegers[i] > Max)
        {
            Max = arrayOfIntegers[i];
        }
    }


    Console.WriteLine($"\nThe Min value is: {Min}");
    Console.WriteLine($"\nThe Max value is: {Max}");
}




