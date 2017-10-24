using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Main
    {
       public static void MainMethod()
        {
            IFactory factoryBike = FactoryCreator.Create("bike");
            factoryBike.Run(937);
            IFactory factoryCar = FactoryCreator.Create("car");
            factoryCar.Run(1234);
        }
    }

    public interface IFactory
    {
        void Run(int miles);
    }

    public class Bike : IFactory
    {
        public void Run(int miles)
        {
            Console.WriteLine(miles);
        }
    }

    public class Car : IFactory
    {
        public void Run(int miles)
        {
            Console.WriteLine($"my bike run for {miles} miles");
        }
    }


    public class FactoryCreator 
    {
        public static IFactory Create(string type)
        {
            IFactory factory = null;
            switch (type)
            {
                case "bike":
                    factory = new Bike();
                    break;
                case "car":
                    factory = new Car();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return factory;
        }
    }
}
