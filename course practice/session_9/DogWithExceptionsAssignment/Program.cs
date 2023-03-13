using System;
namespace DogWithExceptionsAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                Dog DogObject = new Dog();
                //DogObject.Name = "Marco";
                //DogObject.Age = 5;

                DogObject.Name = "Marco";
                DogObject.Age = -5;

                //DogObject.Name = "M";
                //DogObject.Age = 5;

                //DogObject.Name = "Ma";
                //DogObject.Age = 101;

                Console.WriteLine($"Dog name is {DogObject.Name}.");
                Console.WriteLine($"Dog age is {DogObject.Age}.");
            }
            catch (ArgumentException ArgE)
            {
                Console.Error.WriteLine(ArgE);
            }
            catch (ApplicationException AppE)
            {
                Console.Error.WriteLine(AppE);
            }
        }
    }
}

