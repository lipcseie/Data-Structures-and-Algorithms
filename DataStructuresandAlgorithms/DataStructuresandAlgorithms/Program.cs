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

            Console.WriteLine("\nInserting anywhere\n");
            var insertingAnywhere = new InsertingAnywhere();
            var array3 = insertingAnywhere.CreateArray();
            ArrayUtilities.PrintArray(array3);

            Console.WriteLine("\nDelete the last element \n");
            var deleteThelast = new DeletionFromTheEnd();
            var array4 = deleteThelast.DeletionTheLastElement();
            ArrayUtilities.PrintArray(array4);

        }
    }
}
