using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triange
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
          



            Console.Write("Input x of triangle: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input y of triangle: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input z of triangle: ");
            z = Convert.ToInt32(Console.ReadLine());



            if (x == y && y == z)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (x == y || x == z || y == z)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }
    }
}
