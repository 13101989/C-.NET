//// See https://aka.ms/new-console-template for more information

class Project
{
    static void print(string some)
    {
        Console.WriteLine(some);
    }

    static void print(int value)
    {
        Console.WriteLine(value);
    }

    static int RaiseToPower(int value, int power)
    {
        var result = 1;

        for (int i = 0; i < power; i++)
        {
            result = result * value;
        }
        return result;
    }

    static int RaiseToPower(string valueString, string powerString)
    {
        int valueAsNumber = int.Parse(valueString);
        int powerAsNumer = int.Parse(powerString);

        return RaiseToPower(valueAsNumber, powerAsNumer);
    }

    static int RaiseToPower(float value, int power)
    {
        float result = 1;

        for (int i = 0; i < power; i++)
        {
            result = result * value;
        }

        //conversie din float in int
        return (int)result;
    }

    static void sumValues(string message, params int[] values)
    {
        var result = 0;
        foreach (int value in values)
        {
            result += value;
        }

        Console.WriteLine($"{message} = {result}");
    }

    static int GetProduct(int upperLimit, int lowerLimit = 1)
    {
        if (lowerLimit > upperLimit)
        {
            var n = lowerLimit;
            lowerLimit = upperLimit;
            upperLimit = n;
        }

        int result = lowerLimit;

        for (int i = lowerLimit + 1; i <= upperLimit; i++)
        {
            result = result * i;
        }

        return result;
    }

    static int[] RaiseToSquare(int[] source)
    {
        int[] result = new int[source.Length];
        for (int i = 0; i < source.Length; i++)
        {
            result[i] = source[i] * source[i];
        }

        return result;
    }

    static int TestPassThroughValue(int source)
    {
        return source *= source;
    }



    static void Main()
    {

        sumValues("Sum to 3", 1, 2, 3);
        sumValues("Sum to 5", 1, 2, 3, 4, 5);

        var val = RaiseToPower(3, 2);
        Console.WriteLine(val);

        val = RaiseToPower(2, 3);
        Console.WriteLine(val);

        int val2 = RaiseToPower(3, 2);
        Console.WriteLine(val2);

        Console.Write("value = ");
        string value = Console.ReadLine();

        Console.Write("\npower = ");
        string power = Console.ReadLine();

        var powerValue = RaiseToPower(value, power);


        var result = GetProduct(3);
        Console.WriteLine(result);

        result = GetProduct(2, 4);
        Console.WriteLine(result);

        var result2 = int.Parse("2");
        Console.WriteLine(result2);

        result2 = '2';
        Console.WriteLine(result2);



        var a = new int[] { 2, 3, 4 };
        var b = RaiseToSquare(a);

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]} raised to square = {b[i]}");
        }

        var x = 2;
        var y = TestPassThroughValue(x);
        Console.WriteLine($"x = {x} raised to square = {y}");
    }

}






