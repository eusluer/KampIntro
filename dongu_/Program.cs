using System;

namespace dongu_
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "a";
            string kurs2 = "b";
            string kurs3 = "c";

            string[] kurslar = new string[] { "a", "b", "c","d","e","f","g","ğ","ı","i" };



            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
