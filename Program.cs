using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.Area();
            circle.Parimeter();

            Console.WriteLine("Circle Area : " +  circle.Area());
            Console.WriteLine("Circle Perimeter : " + circle.Parimeter());

            Console.ReadKey();
        }

        public interface IShape
        {
            double Area();
            double Parimeter();
        
        }

        public class  Circle : IShape 
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Area()
            {
                return Math.PI * Radius;
            }

            public double Parimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }
    }
}
