using System;

namespace ConWhileOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2, ciftToplam = 0, tekToplam = 0;
            Console.Write("1.sayıyı giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                while (sayi2 < sayi1)
                {
                    if (sayi2 % 2 == 0)
                    {
                        ciftToplam += sayi2;
                    }
                    else
                        tekToplam += sayi2;
                    sayi2++;

                }
            }
            else if (sayi2 > sayi1)
            {
                while (sayi1 < sayi2)
                {
                    if (sayi1 % 2 == 0)
                    {
                        ciftToplam += sayi1;
                    }
                    else
                        tekToplam += sayi1;
                    sayi1++;

                }
            }




        }
    }
}
