using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListProject
{
    public class SinglyLinkedList<T>
    {

        // Head: Points to the first node in the list.
        public Node<T> Head { get; private set; }

        // Tail: Points to the last node in the list.
        public Node<T> Tail { get; private set; }

        // Count: Keeps track of the number of elements in the list.
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            Node<T> temp = Head; // Save the current head
            Head = node;         // Set the new node as the head
            Head.Next = temp;    // Head.Next is being set to the old head
            Count++;

            if (Count == 1)
            {
                Tail = Head; // If the list was empty, set tail to head
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = node; // If the list is empty, set head to the new node
                Tail = node; // Set tail to the new node
            }
            Tail.Next = node; // Link the current tail to the new node
            Tail = node;     //  Update the tail to the new node
            Count++;
        }

        private bool IsEmpty => Count == 0;

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;  // Move head to the next node
            if (Count == 1)
                Tail = null;

            Count--;

        }
    }
}
