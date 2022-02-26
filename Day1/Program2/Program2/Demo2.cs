using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Demo2
    {
        public void Show()
        {
            Console.WriteLine("Hii i am prasad");
        }
         internal  void  Move()
        {
            Console.WriteLine("Working in Mphasis");
        }
        private void Make()
        {
            Console.WriteLine("waiting to do project");
        }

        static void Main(string[] args)
        {
            
            Demo2 obj = new Demo2();
            obj.Show();
            obj.Move();
        }
    }
}
