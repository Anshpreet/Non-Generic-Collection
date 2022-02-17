using System;
using System.Collections.Generic;

namespace QueueOperations
{

    class ObjectClass
    {
        public ObjectClass(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool acceptFlag = true;

            char accept;
            Queue<ObjectClass> list = new Queue<ObjectClass>();
            while (acceptFlag)
            {
                Console.WriteLine("Enter Some strings in stack:");
                string name = Console.ReadLine();
                list.Enqueue(new ObjectClass(name));
                Console.WriteLine("Do you want to continue? Y/N:");
                accept = Convert.ToChar(Console.ReadLine());
                if (accept == 'y')
                    acceptFlag = true;
                else if (accept == 'n')
                    acceptFlag = false;

            }


            foreach (ObjectClass a in list)
            {
                Console.Write(a.Name + ", ");
            }

            Console.WriteLine("Enter index where you want to insert new element:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter element: ");
            string element = Console.ReadLine();
            list = InsertElement(list, index, element);
            foreach (ObjectClass a in list)
            {
                Console.Write(a.Name + ", ");
            }

            Console.WriteLine("Topmost item: " + list.Peek().Name);

            Console.ReadKey();
        }

        private static Queue<ObjectClass> InsertElement(Queue<ObjectClass> list, int index, string element)
        {
            Queue<ObjectClass> tempQueue = new Queue<ObjectClass>();
            ObjectClass obj;
            
            for(int i = 0; i < index; i++)
            {
                obj = list.Dequeue();
                tempQueue.Enqueue(obj);
            }
            tempQueue.Enqueue(new ObjectClass(element));
            for(int i = 0; i <= list.Count; i++)
            {
                obj = list.Dequeue();
                tempQueue.Enqueue(obj);
            }


            return tempQueue;
        }
    }
}
