using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class TravelFactory
    {
        public abstract Travel Create();
    }

    public class PlaneFactory : TravelFactory
    {
        public override Travel Create()
        {
            return new Plane();
        }
    }

    public class TrainFactory : TravelFactory
    {
        public override Travel Create()
        {
            return new Train();
        }
    }

    public abstract class Travel
    {
        public abstract void Show();
    }

    public class Plane : Travel
    {
        public override void Show()
        {
            Console.WriteLine("Plane for Travel");
        }
    }
    public class Train : Travel
    {
        public override void Show()
        {
            Console.WriteLine("Train for Travel");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            TravelFactory planeFactory = new PlaneFactory();
            planeFactory.Create().Show();

            TravelFactory trainFactory = new TrainFactory();
            trainFactory.Create().Show();

            Console.ReadKey();
        }
    }
}