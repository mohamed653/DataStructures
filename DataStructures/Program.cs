using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BTree bTree = new BTree();
            bTree.Add(8);
            bTree.Add(3);
            bTree.Add(10);
            bTree.Add(5);
            bTree.PreOrder(bTree.Root);
            Console.WriteLine();
            bTree.InOrder(bTree.Root);
            Console.WriteLine();
            bTree.PostOrder(bTree.Root);
        }
    }
    class BNode
    {
        public int data;
        public BNode Right;
        public BNode Left;
        public BNode(int data)
        {
            this.data = data;
        }
    }
    /// <summary>
    /// Binary Tree :have at most 2 childern (left child node, right child node)
    /// </summary>
    class BTree
    {
        public BNode Root;
        public int count = 0;
        public void Add(int value)
        {
            BNode bNode = new BNode(value);
            if (Root == null)
            {
                Root = bNode;
            }
            else
            {

                AddTo(Root, value);
            }
            count++;
        }
        public void AddTo(BNode node, int value)
        {
            //declaring new node that wants to be added
            BNode Nnode = new BNode(value);
            if (value < node.data)
            {
                if (node.Left == null)
                {
                    node.Left = Nnode;
                }
                else
                {
                    // *** RECURSION ***
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = Nnode;
                }
                else
                {
                    // *** RECURSION ***
                    AddTo(node.Right, value);
                }
            }
        }
        public void PreOrder(BNode bNode)
        {
            if (bNode!=null)
            {
                Console.WriteLine(" "+bNode.data+" ");
                PreOrder(bNode.Left);
                PreOrder(bNode.Right);
            }
        }
        public void InOrder(BNode bNode)
        {
            if (bNode != null)
            {
                InOrder(bNode.Left);
                Console.WriteLine(" " + bNode.data + " ");
                InOrder(bNode.Right);
            }
        }
        public void PostOrder(BNode bNode)
        {
            if (bNode != null)
            {
                Console.WriteLine(" " + bNode.data + " ");
                PostOrder(bNode.Right);
                PostOrder(bNode.Left);

            }
        }
    }
}
