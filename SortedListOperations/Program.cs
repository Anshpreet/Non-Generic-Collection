using System;
using System.Collections.Generic;

namespace SortedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> name = new SortedList<int, string>();
            SortedList<int, int> age = new SortedList<int, int>();

            name.Add(1, "Anshpreet");
            age.Add(1, 23);
            name.Add(2, "Abhishek");
            age.Add(2, 22);
            name.Add(3, "Simer");
            age.Add(3, 15);

            bool check = GetVoterList(name, age);
            Console.ReadKey();
        }

        private static bool GetVoterList(SortedList<int, string> name, SortedList<int, int> age)
        {
            foreach(var key in age)
            {
                if (key.Value >= 18)
                {
                    foreach(var nkey in name)
                    {
                        if (nkey.Key == key.Key)
                        {
                            Console.WriteLine(key.Key + ".)- " + key.Value + ", " + nkey.Value);
                        }
                    }
                    
                }
            }

            return true;
        }
    }
}
