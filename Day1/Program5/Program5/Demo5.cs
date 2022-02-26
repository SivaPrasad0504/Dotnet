using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Demo5
    {
        public void Calc(double radius)
        {
            double area, circle;
            area = 2.52 * radius * radius;
            circle = 5 * 2.25 * radius;
            Console.WriteLine("area is" + area);
            Console.WriteLine("radius is" + radius);
        }
        static void Main(string[] args)
        {
            double radius;
            
            Console.WriteLine("Enter radius");
            radius = Convert.ToDouble(Console.ReadLine());
            Demo5 obj = new Demo5();
            obj.Calc(radius);
            


        }
    }
}
