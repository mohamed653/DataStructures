using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackArray<string> stackArray = new StackArray<string>(5);
            stackArray.Push("a");
            stackArray.Push("b");
            stackArray.Push("c");
            stackArray.Push("d");
            stackArray.Push("e");
            Console.WriteLine($"{stackArray.Pop()} is poped from stack");
            stackArray.Display();
            Console.WriteLine("POP DISPLAY:");
            stackArray.PopDisplay(stackArray);

        }
    }

    // Implementing Stack Using Array
    class StackArray<T>
    {
        T[] array;
        private int count;
        private int top;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        // Constructor
        public StackArray(int size)
        {
            array = new T[size];
            count = 0;
            top = -1;
        }

        public void Push(T val)
        {
            if (!IsFull())
            {
                array[++top] = val;
                count++;
            }
            else Console.WriteLine("Stack OverFlow!");
        }
        public T Pop()
        {
            if (!IsEmpty())
            {
                count--;
                return array[top--];
            }
            else throw new Exception("Stack UnderFlow!");
        }
        public bool IsEmpty() 
        {
            return (count==0)?true:false;
        }
        public bool IsFull()
        {
            return (count == array.Length) ? true : false;
        }
        public void Display()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($"| {array[i]} |");
            }
            Console.WriteLine("=====");
        }
        public void PopDisplay(StackArray<T> tempStack)
        {
            while (tempStack.Count!=0)
            {
                Console.WriteLine(Pop());
            }         
        }
        public T Peak()
        {
            if (!IsEmpty())
            {
                return array[top];
            }
            else throw new Exception("Stack UnderFlow!");
        }
    }
}
