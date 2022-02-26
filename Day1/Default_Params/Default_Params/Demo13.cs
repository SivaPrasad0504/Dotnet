using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Params
{
    internal class Demo13
    {
        public void Move(String Firstname, String Lastname, String compname = "Mphasis")
        {
            Console.WriteLine("Firstname is" + Firstname);
            Console.WriteLine("Lastname is" + Lastname);
            Console.WriteLine("Compname is" + compname);
            Console.WriteLine(" I am " + Firstname + Lastname + " Working on " + compname);
        }
        static void Main(string[] args)
        {
            Demo13 obj = new Demo13();
            obj.Move("Prasad", "Kona");
            obj.Move("Aravind", "Kethineni", "TechMahindra");
        }
    }
}
