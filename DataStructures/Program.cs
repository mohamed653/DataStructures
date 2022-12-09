using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyStackTrail
            //StackArray<string> stackArray = new StackArray<string>(5);
            //stackArray.Push("a");
            //stackArray.Push("b");
            //stackArray.Push("c");
            //stackArray.Push("d");
            //stackArray.Push("e");
            //Console.WriteLine($"{stackArray.Pop()} is poped from stack");
            //stackArray.Display();
            //Console.WriteLine("POP DISPLAY:");
            //stackArray.PopDisplay(stackArray);
            #endregion

            #region Reverse A string using Stack
            // Reverse A string using Stack

            //Console.WriteLine("Enter the string:");
            //string text = Console.ReadLine();
            //StackArray<char> stackChar = new StackArray<char>(text.Length);
            //for (int i = 0; i < text.Length; i++)
            //{
            //    stackChar.Push(text[i]);
            //}
            //stackChar.PopDisplay(stackChar);
            #endregion
            #region Check if astring is Balanced using Stack
            // Check if astring is Balanced using Stack
            Console.WriteLine(Balanced("{([])}"));
            #endregion
            
            
        }
        static bool Balanced(string text)
        {
            bool flag = true;
            text = text.Trim();
            if (text.Length%2==0)
            {
                int length= text.Length / 2;
                StackArray<char> stack1 = new StackArray<char>(length);
                StackArray<char> stack2 = new StackArray<char>(length);

                for (int i = 0; i < length; i++)
                {
                    stack1.Push(text[i]);
                }
                for (int i = text.Length-1; i >=length; i--)
                {
                    stack2.Push(text[i]);
                }
                for (int i = 0; i < length-1; i++)
                {
                    if (stack1.Pop() != InverseBracket(stack2.Pop()))
                    {
                        return false;
                    }
                }
            }
            else flag = false;
            return flag; 
        }
        static char InverseBracket(char bracket)
        {
            switch (bracket)
            {
                case '[':
                    bracket= ']';
                    break;
                case ']':
                    bracket = '[';
                    break;
                case '{':
                    bracket = '}';
                    break;
                case '}':
                    bracket = '}';
                    break;
                case '(':
                    bracket=')';
                    break;
                case ')':
                    bracket='(';
                    break;
                default:
                    bracket = ' ';
                    break;
            }
            return bracket;
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
                Console.Write(Pop());
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
