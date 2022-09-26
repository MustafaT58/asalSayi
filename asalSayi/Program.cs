using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayi
{
    internal class Program
    {
        public static bool asalMi(int sayi)
        {
            bool durum = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    durum = false;
                    break;
                }
            }
            return durum;
        }
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Sayı Giriniz = ");
            int say = Convert.ToInt32(Console.ReadLine());
            if (asalMi(say))
            {
                Console.WriteLine("{0} sayısı ASALDIR..", say);
            }
            else
            {
                Console.WriteLine("{0} sayısı ASAL DEĞİLDİR::.", say);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Sonraki 5 Asal Sayı");
            Console.WriteLine("--------------------------------");
            while (true)
            {
                say++;
                if (asalMi(say) == true)
                {
                    Console.WriteLine("{0} sayısı ASALDIR..", say);
                    sayac++;
                    if (sayac == 10)
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
