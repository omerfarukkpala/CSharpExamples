using System;

namespace ConDiziOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen adet kadar isim girdirilmeli ve girilen isimler arasından arama yapılmalı



            //1.adım:Kullanıcının kaç tane isim giriceği bilgisini almak
            Console.Write("Kaç isim girilecek");
            int adet = Convert.ToInt32(Console.ReadLine());

            //2.adım Girilen adet boyutunda dizi tanımlanmalı
            string[] isimler = new string[adet];

            //3.adım belirtilen adet kadar kullanıcının isim girmesini sağlamak ve girilen isimleri sıra ile diziye atamak
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write("{0}.İsmi giriniz: ", i + 1);
                isimler[i] = Console.ReadLine();//diziye değerleri atadık.

            }



        }
    }
}
