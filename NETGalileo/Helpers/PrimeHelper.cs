namespace NETGalileo.Helpers
{
    public static class PrimeHelper
    {
        public static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
                return number == 2;

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }

            return number != 1;
        }
    }
}
