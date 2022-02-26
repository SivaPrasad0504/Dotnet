using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseExample2
{
    internal class Demo10
    {
        public void Show(String dayName)
        {
            switch(dayName)
            {
                case "Monday":
                    Console.WriteLine("This is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("This is Tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("This is Wrdnesday");
                    break;
                case " Thursday":
                    Console.WriteLine("This is Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("This is Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("This is Sunday");
                    break;
                default:
                    Console.WriteLine("Its Invaid");
                    break;

            }
        }
        static void Main(string[] args)
        {
            String dayName;
            Console.WriteLine("Enter the Day name");
            dayName = Console.ReadLine();
            Demo10 obj = new Demo10();
            obj.Show(dayName);

        }
    }
}
