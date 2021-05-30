using System;

namespace RemoveDuplicatesFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList node)
        {
            LinkedList current = node;
            if (current == null) return null;
            while(current.next != null)
            {
                if(current.value == current.next.value)
                {
                    current.next = current.next.next;
                }
                current = current.next.next;
            }
            return current;
        }
    }
    public class LinkedList
    {
        public int value;
        public LinkedList next;
        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
