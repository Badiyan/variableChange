using System;


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

            (a,b,c) = (c,a,b);
            Console.WriteLine("a = {0}, \nb = {1}, \nc = {2} ",
                a, b, c);
            Console.ReadKey();

        }
    }
}
