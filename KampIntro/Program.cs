using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           double dolardun=10.50;
            double dolarbugun = 10.80;
            if (dolarbugun>dolardun)
            {
                Console.WriteLine("dolar artışta");
            }
            else if (dolardun>dolarbugun)
            {
                Console.WriteLine("dolar düşüşte");
            }
            else
            {
                Console.WriteLine("dolar eşit");
            }
        }
    }
}
