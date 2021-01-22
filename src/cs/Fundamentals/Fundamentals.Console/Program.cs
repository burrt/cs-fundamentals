using System;
using DataStructure.List;

namespace Fundamentals.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var list = new SinglyLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(new SinglyLinkedListNode<int>(i));
            }

            var curr = list.GetFirst();
            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Next;
            }

        }
    }
}
