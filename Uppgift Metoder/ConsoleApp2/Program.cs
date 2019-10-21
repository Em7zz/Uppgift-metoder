using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));

        }
        static double CirkelArea(double r)
        {
            double R = r * r * 3.14;
            return R;

        }
        static double CirkelOmkrets(double r)
        {
            double R = (r + r) * 3.14;
            return R;

       }
    }
}
