using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Array
            int[] array = new int[] {5,8,9,1,3,4,0};

            // Traversing array
            Traverse(array);
            // Searching element
            int item = SearchElement(array, 9);
            Console.WriteLine($" Index: {item}");

            //Inserting element
            InsertElement(array, 7, 2);
            Traverse(array);

            //Delete element
            DeleteElement(array, 8);
            Traverse(array);

            //Update element
            UpdateElement(array,0,6);
            Traverse(array);

        }
        static void Traverse(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Uses Linear/ Sequental Search
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <returns> the index of the item if exists, -1 if doesn't exists</returns>
        static int SearchElement(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]== element)
                {
                    return i;
                }
            }
            return -1;
        }
        static void InsertElement(int[] arr, int element, int pos)
        {
            for (int i = arr.Length-1; i >= pos; i--)
            {
                arr[i]=arr[i-1];
            }
            arr[pos] = element; 
        }
        static void DeleteElement(int[] arr, int element)
        {
            int pos = SearchElement(arr,element);

            for (int i = pos; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
        }
        static void UpdateElement(int[] arr, int index, int element)
        {
            arr[index] = element;  
        }
    }
}
