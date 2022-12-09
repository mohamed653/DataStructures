using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a directed graph
            Graph gr = new Graph(5);
            gr.AddEdge(0, 1);
            gr.AddEdge(0, 2);
            gr.AddEdge(2, 1);
            gr.AddEdge(1, 3);
            gr.AddEdge(3, 4);
            gr.AddEdge(4, 2);
            Console.Write("Breadth First Traversal from vertex 0:\n");
            gr.BFS(0);
            Console.Write("Depth First Traversal from vertex 0:\n");
            gr.DFS(0);

        }
    }
    /// <summary>
    /// Creating a graph Using Adjacency Lists
    /// </summary>
    class Graph
    {
        // total number of vertices => {n}
        private int vertex;
        // adjacency list {ARRAY OF LISTS} which is {n} number of arrays, each list contains one List
        List<int>[] adjacency;
        public Graph(int vertex)
        {
            adjacency = new List<int>[vertex];
            for (int i = 0; i < adjacency.Length; i++)
            {
                // now we created {n} arrays from adjacency[0]=>adjacency[n-1]
                // this simulate a 2d space
                adjacency[i] = new List<int>();
            }
            this.vertex = vertex;
        }
        // AddEdge adds vertex2 as{item list} to ==> adjacency[vertex1]
        public void AddEdge(int vertex1, int vertex2)
        {
            adjacency[vertex1].Add(vertex2);
        }

        // BreadthFirstSearch using Queue 
        // needs a startVertex because it's a graph
        public void BFS(int startVertex)
        {
            // isVisited is an array with the size of vertcies number : which keep track of the visited vertices while traversing
            bool[] isVisited = new bool[vertex];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // startVertex is visted& Enqueued first 
            isVisited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                Console.WriteLine("next => " + startVertex);

                // Get all adjancency vertices of startVertex
                foreach (int next in adjacency[startVertex])
                {
                    if (!isVisited[next])
                    {
                        isVisited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        // DepthFirstSearch using Stack
        public void DFS(int startVertex)
        {
            bool[] isVisited = new bool[vertex];

            Stack<int> stack = new Stack<int>();
            isVisited[startVertex] = true;
            stack.Push(startVertex);

            while (stack.Count != 0)
            {
                startVertex = stack.Pop();
                Console.WriteLine("next => " + startVertex);
                foreach (int i in adjacency[startVertex])
                {
                    if (!isVisited[i])
                    {
                        isVisited[i] = true;
                        stack.Push(i);
                    }
                }
            }
        }

    }
}
