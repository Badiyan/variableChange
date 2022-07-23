using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variableChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 7;
            int c = 20;

            /* expected
            a = 20;
            b = 1;
            c = 7;
            */

            // 1 variant

            (a,b,c) = (c,a,b);
            Console.WriteLine("a = {0}, \nb = {1}, \nc = {2} ",
                a, b, c);
            Console.ReadKey();

            // 2 variant

            (a, b, c) = (c, a, b);
            Console.WriteLine("a = {0}, \nb = {1}, \nc = {2} ",
                a, b, c);
            Console.ReadKey();
        }
    }
}
