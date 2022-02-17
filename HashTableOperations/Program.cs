using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTableOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hashtable numberNames = new Hashtable();
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            //foreach (DictionaryEntry de in numberNames)
            //    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
             {"UK", "London, Manchester, Birmingham"},
             {"USA", "Chicago, New York, Washington"},
             {"India", "Mumbai, New Delhi, Pune"}
             };

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);


            if (cities.ContainsKey("UK"))
            { 
                cities.Remove("UK");
            }

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            cities.Clear();


            Console.ReadKey();

        }
    }
}
