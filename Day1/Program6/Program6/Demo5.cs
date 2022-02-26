using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Demo5
    {
        public void Check(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");

            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            Demo5 obj = new Demo5();
            obj.Check(n);

        }
    }
}
