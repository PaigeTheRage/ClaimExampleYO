using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the height of your triangle?");
            double height = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double area= Convert.ToDouble(.5 * width * height);
            Console.WriteLine("The area of your triangle is: " + area);
            Console.ReadLine();
        }
    }
    }

