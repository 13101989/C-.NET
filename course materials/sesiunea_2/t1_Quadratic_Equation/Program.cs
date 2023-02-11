double a_double;
double b_double;
double c_double;

double x_1;
double x_2;

double x_1_1;
double x_1_2;
double x_2_1;
double x_2_2;


Console.WriteLine("In order to to solve the quadratic expression (ax^2 + bx + c = 0) please insert values a, b and c, please be aware that the values must be numbers:");

while (true)
{
    Console.WriteLine("Enter value for a (should be different from 0) = ");
    string a = Console.ReadLine();

    Console.WriteLine("Enter value for b = ");
    string b = Console.ReadLine();

    Console.WriteLine("Enter value for c = ");
    string c = Console.ReadLine();


    if (double.TryParse(a, out a_double) && double.TryParse(b, out b_double) && double.TryParse(c, out c_double) && a_double !=0)
    {
        Console.WriteLine("The values you've introduced are: a = {0}, b = {1}, c = {2}", a, b, c);


        if ((b_double * b_double - 4 * a_double * c_double) > 0)
        {
            x_1 = (-b_double + Math.Sqrt(b_double * b_double - 4 * a_double * c_double)) / (2 * a_double);
            x_2 = (-b_double - Math.Sqrt(b_double * b_double - 4 * a_double * c_double)) / (2 * a_double);
            Console.WriteLine("Result is: x1 = {0}, x2 = {1}", x_1, x_2);

        }
        else
        {
            x_1_1 = -b_double / (2 * a_double);
            x_1_2 = (Math.Sqrt((b_double * b_double - 4 * a_double * c_double) * (-1))) / (2 * a_double);

            x_2_1 = -b_double / (2 * a_double);
            x_2_2 = (Math.Sqrt((b_double * b_double - 4 * a_double * c_double) * (-1))) / (2 * a_double);

            Console.WriteLine("Result is: x1 = {0} + {1}i, x2 = {2} - {3}i", x_1_1, x_1_2, x_2_1, x_2_2);
        }

        break;
    }
    else
    {
        Console.WriteLine("The values you've introduced are: a = {0}, b = {1}, c = {2} \n", a, b, c);
        Console.WriteLine("One of the values you have introduced is not a number or the value of 'a' parameter is equal with 0, please insert again the values! \n");
    }
}
