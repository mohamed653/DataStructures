using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BNode<int> rootNode = new BNode<int>(5);
            BNode<int> lnode = new BNode<int>(4);
            rootNode.Left = lnode;
            BNode<int> rnode = new BNode<int>(6);
            rootNode.Right = rnode;
            Console.WriteLine(rootNode.Left.data+" "+ rootNode.Right.data);
        }
    }
    class BNode<T>
    {
        public T data;
        public BNode<T> Right;
        public BNode<T> Left;
        public BNode(T data)
        {
            this.data = data;
        }
    }
}
