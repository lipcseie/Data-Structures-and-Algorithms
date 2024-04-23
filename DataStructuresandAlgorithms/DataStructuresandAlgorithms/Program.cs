using DataStructuresandAlgorithms.Arrays;


namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var insertingAtTheEndOfArray = new InsertingAtTheEndOfArray();
            var array = insertingAtTheEndOfArray.CreateArray();
            insertingAtTheEndOfArray.PrintArray(array);
        }
    }
}
