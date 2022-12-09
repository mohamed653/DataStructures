using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue_Array<int> queue_Array = new Queue_Array<int>(3);
            queue_Array.Enqueue(1);
            queue_Array.Enqueue(2);
            queue_Array.Enqueue(3);
            queue_Array.Display();
            queue_Array.Dequeue();
            queue_Array.Display();
        }
    }

    // Implementing Queue Using Array
    class Queue_Array<T>
    {
        int head;
        int tail;
        int count;
        T[] arr;
        public Queue_Array(int size)
        {
            arr =  new T[size];
            head = tail = -1;
            count = 0;
        }
        public void Enqueue(T val)
        {
            if (tail < arr.Length)
            {
                arr[++tail] = val;
                head = 0;
                count++;
            }
            else
            {
                Console.WriteLine("Queue OverFlow!");
            }
        }
        public T Dequeue()
        {
            if (!IsEmpty())
            {
                T value = arr[head];
                // WOW works like a magic 
                arr[head]= default;
                head++;
                count--;
                return value;
            }
            else
            {
                // WOW works like a magic 
                return default;
            }
        }
        public void Display()
        {
            Console.WriteLine(new string('_', count*3));
            foreach (var item in arr)
            {
                // i have to do this
                if (item.ToString()!="0")
                {
                Console.Write(item + ", ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', count*3));
        }
        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            return false;
        }
    }

}
