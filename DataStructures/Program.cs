using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<double> one = new Node<double>(1);
            Node<double> two = new Node<double>(2);
            Node<double> five = new Node<double>(5);
            one.Next= two;
            two.Next= five;
            Console.WriteLine(one.Next.Data);
        }
    }
    class Node<T>
    {
        T data;
        Node<T> next;
        public Node(T data)
        {
            this.data = data;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
