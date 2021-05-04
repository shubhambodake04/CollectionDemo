using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection");
            Do_Stack();
            Do_List();
            Do_Dictionary();
            Do_Set();
            Do_Queue();
        }

        private static void Do_Stack()
        {
            Console.WriteLine("\nIn Do_Stack Demo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            //Iterate stack elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(("popped element: " + pop));
        }
        private static void Do_List()
        {
            Console.WriteLine("\nIn Do_List Demo");
            List<string> list = new List<string>();

            //Adding object to the list
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            //Iterate list elements
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        private static void Do_Dictionary()
        {
            Console.WriteLine("\n In Do_Dictionary Demo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Shubham");
            dictionary.Add(101, "Abhi");
            dictionary.Add(102, "Rushi");
            Console.WriteLine("Access value at key=102 " + dictionary[102]);

            Console.WriteLine("\nIterating dictionary ");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Keys = " + element.Key + " & Values = " + element.Value);
            }
        }

        private static void Do_Set()
        {
            Console.WriteLine("\nIn Do_Set Demo");

            var set = new HashSet<string>();
            set.Add("Shubham");
            set.Add("Ram");
            set.Add("Sham");
            set.Add("Ravi");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("HashSet Values " + enumerator.Current);
            }
        }

        private static void Do_Queue()
        {
            Console.WriteLine("\nIn Do_Queue Demo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("\n Iterating the queue element:");

            //Iterating through queue elements
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeued Element :" + dequeue);

            Console.WriteLine("\nIterarating the queue elements after dequeue one Element: ");
             //Iteratring queue elements using Enumerator
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }

}
