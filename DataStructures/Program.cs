using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<double> nOne = new Node<double>(1);
            Node<double> nTwo = new Node<double>(2);
            Node<double> nFive = new Node<double>(5);
            Node<double> nSeven = new Node<double>(7);
            Node<double> nEight = new Node<double>(8);
            Node<double> nFour = new Node<double>(4);
            //one.Next= two;
            //two.Next= five;
            //Console.WriteLine(one.Next.Data);

            //Contructing the linked list
            Linked_List<double> linked_List = new Linked_List<double>();
            linked_List.AddEndNode(nOne);
            linked_List.AddEndNode(nTwo);
            linked_List.AddEndNode(nFive);
            linked_List.AddEndNode(nSeven);
            linked_List.AddEndNode(nEight);
            linked_List.AddEndNode(nFour);

            //Traverseing the linked list
            Console.WriteLine("Traverseing the linked list");
            linked_List.Traverse();

            // Searching the linked list by node
            Console.WriteLine("Searching the linked list by node");
            int nodePosition = linked_List.GetPostion(nFive);
            Console.WriteLine($"{nodePosition}");

            // Searching the linked list by postion
            Console.WriteLine("Searching the linked list by postion");
            Node<double> mynode = linked_List.SearchNode(3);
            Console.WriteLine($"mynode data: {mynode.Data}");

            // Removing a node in linked list
            Console.WriteLine("Removing a node in linked list");
            linked_List.RemoveNode(nTwo);
            linked_List.Traverse();

            // Clearing LinkedList
            Console.WriteLine("Clearing LinkedList");
            linked_List.ClearList();
            linked_List.Traverse();

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
    class Linked_List<T>
    {
        Node<T> head;
        Node<T> tail;
        public int Size; 

        public Linked_List()
        {
            head = tail = null;
            Size = 0;
        }
        public void AddEndNode(Node<T> node)
        {
            if (head ==null)
            {
                head =tail= node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Size++;
        }
        public void Traverse()
        {
            Node<T> current = head;
            while (current!=null)
            {
                Console.Write($"{current.Data} => ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
        public int GetPostion(Node<T> node)
        {
            int pos=1;
            Node<T> current = head;
            while (current!=null)
            {
                // can't use == |  so i used Equals()   it can work with any obj 
                if (current.Data.Equals(node.Data))
                {
                    return pos;
                }
                current = current.Next;
                pos++;
            }
            return -1;
        }
        public Node<T> SearchNode(int pos)
        {
            Node<T> fNode=head;
            for (int i = 1; i < pos; i++)
            {
                fNode = fNode.Next;
            }
            if (fNode!=null)
            {
                return fNode;
            }
            throw new Exception("No Node Found!");
        }

        // you have three cases:
        //the node we want to remove is => 
        // 1- theHeadNode
        // 2- theTailNode
        // 3-  a middle node "which is not a head or a tail node"
        public void RemoveNode(Node<T> rNode)
        {
            int rPos = GetPostion(rNode);
            // finding the previous node for case 2&3
            Node<T> prevNode = SearchNode(rPos - 1);
            if (rPos==1)
            {
                // this means that rNode is the headNode
                head = head.Next;
                // i used rNode as a temp
                rNode.Next = null;
            }
            else if (rPos==Size)
            {
                // this means that rNode is the tailNode
                tail = prevNode;
                prevNode.Next = null;
            }
            else
            {
                prevNode.Next = rNode.Next;
                rNode.Next = null;
            }
        }

        public void ClearList()
        {
            head = tail=null;
        }
    }
}
