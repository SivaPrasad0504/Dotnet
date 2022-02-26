using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Demo4
    {
        public void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("sum is " + c);
        }
        public void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("sub is +" + c);
        }

        public void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Mul is " + c);

        }
        public void Div( int a, int b)
        {
            int c = a / b;
            Console.WriteLine("div is " + c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine(" Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Demo4 obj = new Demo4();
            obj.Sum(a, b);
            obj.Mul(a, b);
            obj.Sub(a, b);
            obj.Div(a, b);


            
        }
    }
}
