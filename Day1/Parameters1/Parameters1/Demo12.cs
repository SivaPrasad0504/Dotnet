using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters1
{
    internal class Demo12
    {
        public void Show(params string[] names)
        {
            foreach(String s in names)
            {
                Console.WriteLine("Student name is "+ s);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Demo12 obj = new Demo12();
            obj.Show();
            obj.Show("Arka", "Prasad", "Momitha");
            obj.Show("Arka", "Prasad", "Momitha", "Sresta");
            


        }
    }
}
