using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Demo11
    {
        public void Show()
        {
            String[] names = new string[]
            {
                "Momitha Roy","Prasad","Sresta","Santhosh","Yashwanth"
            };
            foreach(String name in names)
            {
                Console.WriteLine(name);
            }
        }
        

        static void Main(string[] args)
        {
            Demo11 obj = new Demo11();
            obj.Show();
        }
    }
}
