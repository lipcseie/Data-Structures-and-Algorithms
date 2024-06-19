namespace Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 5 };
            Node second = new Node() { Value = 1 };

            first.Next = second;

            Node third =  new Node() { Value = 3 };
            second.Next = third;

            PritOutlinkedList(first);
        }

        private static void PritOutlinkedList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
