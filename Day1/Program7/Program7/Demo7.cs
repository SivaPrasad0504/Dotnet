using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Demo7
    {
        public void Check(int a ,int b, int c)
        {
            int m = a;
            
                if (m < b)
                {
                    m = b;
                }
            if (m < c) 
            {
                m = c;
            }
            Console.WriteLine("Maximum value is " + m);
            
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Demo7 obj = new Demo7();
            obj.Check(a,b,c);
        }
    }
}
