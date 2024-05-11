namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(LinearSearch(array, 5));
        }

        public static bool LinearSearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            if (target < 0 )
            {
                throw new ArgumentException("Target must be a positive integer");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
