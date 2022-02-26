using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strmethos
{
    internal class Demo8
    {
        public void Show()
        {
            string str = "Welcome to the vijayawada";
            Console.WriteLine("Length of String is" + str.Length);
            Console.WriteLine("First occurence of a is" + str.IndexOf("a"));
            String s1= "Prasad", s2= "Ravi" , s3 = "Prasad";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));

            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s2.ToLower());


        }

        static void Main(string[] args)
        {
            Demo8 obj = new Demo8();
            obj.Show();
        }
    }
}
