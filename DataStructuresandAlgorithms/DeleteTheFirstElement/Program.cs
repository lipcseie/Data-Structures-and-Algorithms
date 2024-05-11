namespace DeleteTheFirstElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6 };
            int[] result = DeleteTheFirstElement(originalArray);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] DeleteTheFirstElement(int[] array)
        {
            if( array == null || array.Length ==0 )
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int length = array.Length;
            int[] newArray = new int[length - 1];

            for ( int i = 1; i < length; i++ )
            {
                newArray[i - 1] = array[i];
            }
            return newArray;
        }
    }
}
