using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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


    }
}
