using System;
using System.Collections;

namespace ArrayListObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            bool acceptFlag = true;
            
            char accept;
            ArrayList names = new ArrayList();
            while (acceptFlag)
            {
                Console.WriteLine("Enter Some Integer:");
                string name = Console.ReadLine();
                names.Add(new CisPerson(name));
                Console.WriteLine("Do you want to continue? Y/N:");
                accept = Convert.ToChar(Console.ReadLine());
                if (accept == 'y')
                    acceptFlag = true;
                else if (accept == 'n')
                    acceptFlag = false;

            }
            CisPerson obj = new CisPerson();
           
            foreach(CisPerson a in names)
            {
                Console.WriteLine(a.Name);
            }
            Console.ReadKey();
        }
    }
}
