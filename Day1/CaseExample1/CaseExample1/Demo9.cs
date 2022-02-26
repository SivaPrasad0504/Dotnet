using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseExample1
{
    internal class Demo9
    {
        public void Show(int n)
        {
            switch(n)
            {
                case 1:
                    Console.WriteLine("Hii i am naveen");
                    break;
                case 2:
                    Console.WriteLine("Hi i am prasad");
                    break;
                case 3:
                    Console.WriteLine(54);
                    break;
                case 4:
                    Console.WriteLine("I am Learning Dotnet");
                    break;
                default:
                    Console.WriteLine("Invaid Choice");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int Choice;
            Console.WriteLine("Choose the Choice");
            Choice=Convert.ToInt32(Console.ReadLine());
            Demo9 obj = new Demo9();
            obj.Show(Choice);

        }
    }
}
