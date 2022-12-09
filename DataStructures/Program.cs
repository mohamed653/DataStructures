using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
  //// 1. create a hashtable
  //          Hashtable myTable = new Hashtable();

  //          // 2. add items to hashtable
  //          myTable.Add("Name", "Ginny");
  //          myTable.Add("RollNumber", 12);
  //          myTable.Add("Address", "Miami");
  //          myTable.Add("key", "value");

  //          // 3. remove element
  //          myTable.Remove("key");

  //          // 4. Access Hashtable
  //          var i = myTable["Address"];

  //          // 5. iterate/ traverse through hashtables
  //          foreach (DictionaryEntry item in myTable)
  //          {
  //              Console.WriteLine(item.Key);
  //          }
            #endregion

            #region Dictionary
            //// 1. create a dictionary
            //Dictionary<int, string> country = new Dictionary<int, string>()
            //{ { 5, "Brazil" },{ 3, "China" },{ 4, "USA" } };

            //// 2.iterate through dictionary 
            //foreach (KeyValuePair<int, string> items in country)
            //{
            //    Console.WriteLine("{0} : {1}", items.Key, items.Value);
            //}

            #endregion
            #region Binding complex objects into dictionaries 

            Dictionary<char, List<Student>> YearBook = new Dictionary<char, List<Student>>();
            List<Student> Astudents = new List<Student>()
            
            {
                new Student{Name="Ahmed", Gpa=3.7M },
                new Student{Name="Ali", Gpa=2.7M },
                
                
            };
            List<Student> Bstudents = new List<Student>() {
                new Student { Name = "Bruce", Gpa = 3.1M }, 
            };
            List<Student> Cstudents = new List<Student>() {
                new Student{Name="Chris", Gpa=2.9M }
            };
            YearBook.Add('a', Astudents);
            YearBook.Add('b', Bstudents);
            YearBook.Add('c', Cstudents);
            
            foreach (KeyValuePair<char, List<Student>> keyValue in YearBook)
            {
                Console.Write(keyValue.Key+", ");
                for (int i = 0; i < keyValue.Value.Count; i++)
                {
                    Console.Write($"[ {keyValue.Value[i].Name} : {keyValue.Value[i].Gpa} ], ");
                }
                Console.WriteLine();
            }
            #endregion
        }
        class Student
        {
            public string Name { get; set; }
            public decimal Gpa { get; set; }

        }
    }
}
