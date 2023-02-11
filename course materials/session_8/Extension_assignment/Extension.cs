using System;

namespace Extension_assignment
{
    public static class IntExtension
    {
        public static bool CompareAge(this uint age, uint ageToCompare)
        {
            return age > ageToCompare;
        }

        public static bool IsAdult(this uint checkAdulthood)
        {
            return checkAdulthood >= 18;
        }

        public static bool CheckIfPrime(this uint number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for ( int i = 3; i <= limit; i++)
                if (number % i == 0)
                {
                    return false;
                }
            return true;
        }
    }
}