using System;

namespace ConDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               * 
               * Döngüler
               * Belirli kod bloğunu belirli bir koşula göre tekrar tekrar çalıştırmayı sağlayan yapılardır
               * 
               * 4 tane döngü çeşidi vardır
               * 
               * 1-while döngüsü
               * while(){
               * 
               * }
               *  
               */
            int sayi = 100;
            while (sayi > 0)
            {
                Console.WriteLine("Merhaba dünya--{0}", sayi);
                sayi--;

            }
        }
    }
}
