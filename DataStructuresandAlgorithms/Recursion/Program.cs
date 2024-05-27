namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IterativeFactioral(10));
            Console.WriteLine(RecursiveFactorial(10));
        }

        private static int IterativeFactioral(int number)
        {
            if (number == 0)
                return 1;

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        // 1! = 1 * 0! = 1
        // 2! = 2 *1 = 2 * 1!
        // 3! = 3 * 2 * 1 = 3 * 2!
        // 4! = 4 * 3 * 2 * 1 = 4 * 3!
        // 4! = 4 * 3!
        // n! = n * (n - 1)!

        // 1 * RecursiveFactorial(1 - 1) = 1 -> 
        // 2 * RecursiveFactorial(2 - 1) = 2 ->
        // 3 * RecursiveFactorial( 3 - 2) = 3 * 2 = 6
        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * RecursiveFactorial(n - 1);
        }
    }
}
