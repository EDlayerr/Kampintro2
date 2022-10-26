using System;

namespace KampIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            string meyveler = "Elma";
            int elmaTuru = 5;
            double fiyat = 2.50;
            bool envanterdevarmi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }

            else
            {
                Console.WriteLine("Eşittir oku");
            }

            if (envanterdevarmi==true)
            {
                Console.WriteLine("Stokta var");
            }

            else
            {
                Console.WriteLine("Stokta Ürün Yok");
            }

            Console.WriteLine(meyveler);
            Console.WriteLine(elmaTuru);
            Console.WriteLine(fiyat);
            Console.WriteLine("****************");

            String[] isimler = new string[] { "Enes", "Emre", "Kaan", "Tarık" };
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
