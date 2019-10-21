using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal1 = 3.6;
            double tal2 = 5.1;
            double tal3 = 39.9;
            double Medelvärde = BeräknaMedelvärde(tal1, tal2, tal3);
            Console.WriteLine("Medelvärde " + Medelvärde);
        }   
         static double BeräknaMedelvärde(double tal1, double tal2, double tal3)
        {
            return tal1 + tal2 + tal3 / 3;
        }
        
    }
}
