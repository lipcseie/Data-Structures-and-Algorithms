using DataStructuresandAlgorithms.Arrays;


namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInserting at the end of an array\n");
            var insertingAtTheEndOfArray = new InsertingAtTheEndOfArray();
            var array = insertingAtTheEndOfArray.CreateArray();
            ArrayUtilities.PrintArray(array);

            Console.WriteLine("\nInserting at the start of an array\n");
            var insertingAtTheStartOfArray = new InsertingAtTheStartOfArray();
            var array2 = insertingAtTheStartOfArray.CreateArray();  
            ArrayUtilities.PrintArray(array2);
        }
    }
}
