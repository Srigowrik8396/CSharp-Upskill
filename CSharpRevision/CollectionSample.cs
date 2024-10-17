using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevision
{
    class CollectionSample
    {
        public int id { get; set; }
            //Non-Generic Collection ArrayList / HashTable

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Ram");
            //arrayList.Add("Shyam");
            //arrayList.Add("Vikram");
            //arrayList.Add(123);

            //Console.WriteLine("--------Array List Value-----");
            //for (int i = 0; i <= arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            ////Hash table
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Ram");
            //hashtable.Add("Shyam", 2);
            //hashtable.Add(3, "Rani");
            //hashtable.Add(4, "Samy");
            //hashtable.Add("Vikram", 5);
            //hashtable.Remove(1);

            //Console.WriteLine("--------Hash table Value-----");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}
            ////Dictionary
            //Dictionary<int, string> dataBook = new Dictionary<int, string>();
            //dataBook.Add(1, "Sam");
            //dataBook.Add(2, "Ram");
            //dataBook.Add(3, "Venu");

            //Console.WriteLine("--------Dictionary Value-----");
            //for (int i = 0; i < dataBook.Count; i++)
            //{
            //    Console.WriteLine($"{dataBook.Keys.ElementAt(i)} : {dataBook.Values.ElementAt(i)}");
            //}

            //Stack stackValue = new Stack();
            //stackValue.Push("Add");
            //stackValue.Push("Sub");
            //stackValue.Push("Mul");
            //stackValue.Push("Div");

            //Console.WriteLine("---------------- ");
            //Console.WriteLine("The values are in last: ", stackValue.Peek());
            //Console.WriteLine("---------------- ");
            //while (stackValue.Count > 0)
            //{
            //    Console.WriteLine(stackValue.Pop());
            //}

    }
}
