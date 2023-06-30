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
            Maximum maximum = new Maximum();
            Console.WriteLine("Enter the FirstNumber");
            float firstvalue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            float secondvalue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            float thirdvalue = Convert.ToSingle(Console.ReadLine());
            float val = maximum.Number(firstvalue, secondvalue, thirdvalue);
            Console.WriteLine("{0} is largest number ", val);
            Console.ReadLine();
        }
    }
}
