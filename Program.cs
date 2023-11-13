using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Salary
{
    internal class Program
    {

        public void salary(double wHour, int nWDays, int projectHandles, int extras)
        {
            double salary = wHour * nWDays * 100 + projectHandles * 3000 + extras*2000;
            Console.WriteLine(salary);
        }
        static void Main(string[] args)
        {

            Program x = new Program();
            Console.WriteLine("Salary of the HR is: ");
            x.salary(8, 30, 1, 0);
            Console.WriteLine("Salary of the Admin is: ");
            x.salary(8, 30, 2, 0);
            Console.WriteLine("Salary of the Software Developer is is: ");
            x.salary(8, 30, 4, 5);

            Console.ReadKey();

        }
    }
}
