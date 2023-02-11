public class DetermineMinMax
{

    static void Main()
    {
        Console.WriteLine("Please insert the number of integers for which you want to calculate the min and max (at least 2):");

        var numberOfIntegersInput = GetNumberOfIntegersInput();

        if (string.IsNullOrEmpty(numberOfIntegersInput))
        {
            Console.WriteLine($"Exited beacause value introduced is not a valid integer.");
            return;
        }

        //Func<string> integersInput = GetIntegersInput;
        var integersInput = GetIntegersInput(numberOfIntegersInput);

        if (string.IsNullOrEmpty(integersInput))
        {
            Console.WriteLine($"Exited beacause value introduced is not a valid integer.");
            return;
        }

        Console.WriteLine($"\nThe numbers you have introduced are: {integersInput}");


        Func<string, int> Min = CalculateMin;
        Func<string, int> Max = CalculateMax;
        //int Min = CalculateMin(integersInput);
        //int Max = CalculateMax(integersInput);

        Console.WriteLine($"\nThe Min value is: {Min(integersInput)}");
        Console.WriteLine($"\nThe Max value is: {Max(integersInput)}");
    }


    static string GetNumberOfIntegersInput()
    {
        string? numberOfElements = Console.ReadLine();

        if (int.TryParse(numberOfElements, out int value) == false || value < 2)
        {
            return String.Empty;
        }
        return numberOfElements;
    }


    static string GetIntegersInput(string numberOfElements)
    {
        string numbers = "";

        for (int i = 0; i < Convert.ToInt32(numberOfElements); i++)
        {
            Console.WriteLine($"Please insert number {i + 1} out of {numberOfElements}:");
            string? stringNumber = Console.ReadLine();

            if (int.TryParse(stringNumber, out _) == false || stringNumber == "-0")
            {
                return String.Empty;
            }
            else
            {
                numbers += stringNumber + " ";
            }
        }
        return numbers;
    }


    static int CalculateMin(string numbers)
    {
        string[] arrayOfStrings = numbers.Split(" ");
        int[] arrayOfIntegers = new int[arrayOfStrings.Length - 1];

        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = Convert.ToInt32(arrayOfStrings[i]);
        }

        int Min = arrayOfIntegers[0];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            int.TryParse(arrayOfStrings[i], out arrayOfIntegers[i]);
            if (arrayOfIntegers[i] < Min)
            {
                Min = arrayOfIntegers[i];
            }
        }

        return Min;
    }

    static int CalculateMax(string numbers)
    {
        string[] arrayOfStrings = numbers.Split(" ");
        int[] arrayOfIntegers = new int[arrayOfStrings.Length - 1];

        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            arrayOfIntegers[i] = Convert.ToInt32(arrayOfStrings[i]);
        }

        int Max = arrayOfIntegers[0];
        for (int i = 0; i < arrayOfIntegers.Length; i++)
        {
            if (arrayOfIntegers[i] > Max)
            {
                Max = arrayOfIntegers[i];
            }
        }
        return Max;
    }
}