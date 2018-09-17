using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathDLL;

namespace RandomPersonsMathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathDLL.MyMathClass math = new MyMathClass();
            Console.WriteLine(math.Add(3, 4));
            Console.WriteLine(math.Divide(4, 2));
            Console.WriteLine(math.Multiply(5, 88));
            Console.WriteLine(math.Subtract(5, 6));
            Console.ReadLine();
        }
    }
}
