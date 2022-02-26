using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Demo10
    {
        public void Show()
        {
            int[] a= new int[]{ 1,15,25,45,52};
            //for(int i=0;i<a.Length;i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

    

        static void Main(string[] args)
        {
        Demo10 obj = new Demo10();
        obj.Show();

        }
    }
}
