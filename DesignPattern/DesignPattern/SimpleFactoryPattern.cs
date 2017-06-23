using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DesignPattern
{
    public class TravelFactory
    {
        public static Travel Create(string name)
        {
            switch (name)
            {
                case "Plane":
                    return new Plane();
                case "Train":
                    return new Train();
                case "Bus":
                    return new Bus();
                default:
                    break;

            }

            throw new Exception("There is no relative class for name");
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
    public class Bus : Travel
    {
        public override void Show()
        {
            Console.WriteLine("Bus for Travel");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var plane = TravelFactory.Create("Plane");
            plane.Show();

            var train = TravelFactory.Create("Train");

            train.Show();
            var bus = TravelFactory.Create("Bus");

            bus.Show();

            Console.ReadKey();
        }
    }
}
