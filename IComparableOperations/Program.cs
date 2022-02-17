using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableOperations
{
    public class Car : IComparable
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Car))
            {
                throw new ArgumentException("Compared Object is not of car");
            }
            Car car = obj as Car;
            return Name.CompareTo(car.Name);
        }
    }


    public class CarComparer : IComparer<Car>
    {
        public enum SortBy
        {
            Name,
            MaxSpeed
        }
        public SortBy compareField = SortBy.Name;
        public int Compare(Car x, Car y)
        {
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);
                    
                case SortBy.MaxSpeed:
                    return x.MaxSpeed.CompareTo(y.MaxSpeed);
                   
                default:
                    break;
            }
            return x.Name.CompareTo(y.Name);
        }
    }

    class Employee : IEquatable<Car>
    {
        public string Name
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public bool Equals(Car obj)
        {
            return ((Name==obj.Name) && (MaxSpeed == obj.MaxSpeed));
        }

    }

    public class Program
    {


        static void Main(string[] args)
        {

            Car[] cars = new Car[]
            {
               new Car()
               {
                 Name = "Range Rover",
                 MaxSpeed=3
               }, 
                new Car()
               {
                 Name = "lamborghini",
                 MaxSpeed=4
               },
                new Car()
               {
                 Name = "BMW",
                 MaxSpeed=2
               }
            };
            Array.Sort(cars);
            Console.WriteLine("IComparable List");
            Array.ForEach(cars, x => Console.WriteLine(x.Name));


            var carComparer = new CarComparer();
            carComparer.compareField = CarComparer.SortBy.MaxSpeed;
            Array.Sort(cars, carComparer);
            Console.WriteLine("IComparer List");
            Array.ForEach(cars, x => Console.WriteLine(x.MaxSpeed +", "+ x.Name));

             List<Car> carList = new List<Car>();
            
             Car obj = new Car()
            {
              Name ="BMW",
              MaxSpeed = 2  
            };
            carList.Add(obj);
            Console.WriteLine("IEquatable Result");
            if (carList.Contains(obj))  
             Console.WriteLine("The list already contains this car.");  
         

            Console.ReadLine();

        }
    }
}
