using DataStructuresandAlgorithms.Arrays;


namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine();
            var deleteTheFirstElement = new DeleteTheFirstElement();    
            var array5 = deleteTheFirstElement.DeleteTheFirstElementFromTheArray();
            ArrayUtilities.PrintArray(array5);

        }
    }
}
