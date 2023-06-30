using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] value = { 1, 2, 3, 4, 5 };
            double[] value_one = { 9.4, 5.7, 8.4, 3.6 };
            string[] value_two = { "Sai", "Bridge", "Satya" };

            Maximum<int> obj = new Maximum<int>(value);
            int MaxInt = obj.Number();
            Console.WriteLine("Maximum value in integer is: " + MaxInt);
            Maximum<double> obj_one = new Maximum<double>(value_one);
            double MaxDouble = obj_one.Number();
            Console.WriteLine("Maximum value in double is: " + MaxDouble);
            Maximum<string> obj_Two = new Maximum<string>(value_two);
            string MaxString = obj_Two.Number();
            Console.WriteLine("Maximum value in string is: " + MaxString);

            Console.ReadLine();
        }
    }
}
