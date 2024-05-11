using DataStructuresandAlgorithms.Arrays;


namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {


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
