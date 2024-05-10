using DataStructuresandAlgorithms.Arrays;


namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInserting at the start of an array\n");
            var insertingAtTheStartOfArray = new InsertingAtTheStartOfArray();
            var array2 = insertingAtTheStartOfArray.CreateArrayWithInsertAtStart();  
            ArrayUtilities.PrintArray(array2);

            Console.WriteLine("\nInserting anywhere\n");
            var insertingAnywhere = new InsertingAnywhere();
            var array3 = insertingAnywhere.CreateArrayInsertAtnAnywhere();
            ArrayUtilities.PrintArray(array3);

            Console.WriteLine("\nDelete the last element \n");
            var deleteThelast = new DeletionFromTheEnd();
            var array4 = deleteThelast.DeleteTheLastElement();
            ArrayUtilities.PrintArray(array4);

            Console.WriteLine();
            var deleteTheFirstElement = new DeleteTheFirstElement();    
            var array5 = deleteTheFirstElement.DeleteTheFirstElementFromTheArray();
            ArrayUtilities.PrintArray(array5);

        }
    }
}
