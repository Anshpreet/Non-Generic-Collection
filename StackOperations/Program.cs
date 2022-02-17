using System;
using System.Collections.Generic;
namespace StackOperations
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
            Stack<ObjectClass> list = new Stack<ObjectClass>();
            while (acceptFlag)
            {
                Console.WriteLine("Enter Some strings in stack:");
                string name = Console.ReadLine();
                list.Push(new ObjectClass(name));
                Console.WriteLine("Do you want to continue? Y/N:");
                accept = Convert.ToChar(Console.ReadLine());
                if (accept == 'y')
                    acceptFlag = true;
                else if (accept == 'n')
                    acceptFlag = false;

            }
            

            foreach (ObjectClass a in list)
            {
                Console.Write(a.Name+", ");
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

        private static Stack<ObjectClass> InsertElement(Stack<ObjectClass> list, int index, string element)
        {
            Stack<ObjectClass> tempStack = new Stack<ObjectClass>();
            ObjectClass obj;
            for (int i=list.Count; i>=index;i--)
            {
                if (index == 0)
                    break;
                else
                {
                    obj = list.Pop();
                    tempStack.Push(obj);
                    index--;
                }
            }
            list.Push(new ObjectClass(element));
            for(int i=0;i<=tempStack.Count;i++)
            {
                obj = tempStack.Pop();
                list.Push(obj);
            }
            return list;
        }
    }
}
