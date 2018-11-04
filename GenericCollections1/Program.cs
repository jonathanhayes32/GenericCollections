using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is an instantiated instance of a List<T>
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.Write("Here is a List: ");
            foreach (var i in list)
            {
                Console.Write($"{i} ");
            }
            //Here is an istantiated instance of a Linked List
            Console.Write("\n\n\nHere is a Linked List: ");
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(6);
            ll.AddAfter(ll.First, 10);
            ll.AddAfter(ll.First, 9);
            ll.AddAfter(ll.First, 8);
            ll.AddAfter(ll.First, 7);
            foreach (var i in ll)
            {
                Console.Write($"{i} ");
            }

            Queue<string> Queueinstance = new Queue<string>();
            Queueinstance.Enqueue("here is number 1");
            Queueinstance.Enqueue("here is number 2");
            Queueinstance.Enqueue("here is number 3");
            Queueinstance.Enqueue("here is number 4");
            Queueinstance.Enqueue("here is number 5");
            Console.Write("\n\n\nHere is a Queue: ");
            foreach (var i in Queueinstance)
            {
                Console.Write($"{i} ");
            }

            Console.Write("\n\n\nHere is a Stack: ");
            //Here is an instantiated instance of a stack
            Stack<int> Stackinstance = new Stack<int>();
            Stackinstance.Push(11);
            Stackinstance.Push(12);
            Stackinstance.Push(13);
            Stackinstance.Push(14);
            Stackinstance.Push(15);
            foreach (var i in Stackinstance)
            {
                Console.Write($"{i} ");
            }


            //Here is an instantianted instance of a dictionary<TKey, TValue>
            Dictionary<int, string> Dictionarypairs = new Dictionary<int, string>();
            Dictionarypairs.Add(1, "dogs");
            Dictionarypairs.Add(2, "cats");
            Dictionarypairs.Add(3, "monkeys");
            Dictionarypairs.Add(4, "snakes");
            Dictionarypairs.Add(5, "tigers");
            Console.Write("\n\n\nDictionary: ");
            foreach (KeyValuePair<int, string> pair in Dictionarypairs)
            {
                Console.Write($"Key = {pair.Key}, Value = {pair.Value}");
            }
            //Here is an instantiated instance of a SortedList<Tkey,TValue>
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(2, "7");
            sortedList.Add(1, "6");
            sortedList.Add(3, "8");
            sortedList.Add(4, "9");
            sortedList.Add(5, "10");
            Console.Write("\n\n\n Here is a SortedList: ");
            foreach (KeyValuePair<int, string> kvp in sortedList)
            {
                Console.Write($"Key = {kvp.Key}, Value = {kvp.Value} ");
            }


            //gere is an instantiated instance of a HashSet<T>
            HashSet<int> Hashsetinstance = new HashSet<int>();
            for (int i = 0; i < 11; i++)
            {
                Hashsetinstance.Add(i * 2);
            }
            Console.Write("\n\n\nHere is a Hash Table: ");
            foreach (var i in Hashsetinstance)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
