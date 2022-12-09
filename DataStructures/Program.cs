using System;
using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. create a hashtable
            Hashtable myTable = new Hashtable();

            // 2. add items to hashtable
            myTable.Add("Name", "Ginny");
            myTable.Add("RollNumber", 12);
            myTable.Add("Address", "Miami");
            myTable.Add("key", "value");

            // 3. remove element
            myTable.Remove("key");

            // 4. Access Hashtable
            var i = myTable["Address"];

            // 5. iterate/ traverse through hashtables
            foreach (DictionaryEntry item in myTable)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
