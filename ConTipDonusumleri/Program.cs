﻿using System;

namespace ConTipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          *Tip Dönüşümleri:Bir tipteki değeri başka bir tipe dönüştürmeyi sağlar
          *
          * 1-Cast:
          * 1-1 Implictly Cast:
          * Kendi Kendine dönüşüm işlemi yapar.
          * Bizim ayrıca dönüşüm işlemi yapmamıza gerek yoktur.
          * Not:Kesinlikle bir tip diğer tipin içerisinde barınabiliyorsa gerçekleşir.
          * 
          * 1-2:Explicitly cast:
          * Benzer tipler dönüşüm yapmayı sağlar
          * Bu kez dönüşüm işlemini biz yaparız
          * 
          * 2-Convert ve Parse 
          * Cast işleminin yetersiz odluğu durumlarda kullanılır
          * Metinsel bir ifadeyi cast yöntemi ile bir tipe dönüşütüremeyiz.

          * 2-1.Parse:
          * Sadece string bir değeri başka bir tipe dönüştürmeyi sağlar
          * Her  tipin içerisinde parse metodu bulunur
          * Converte göre daha performanslıdır. fakat daha yeteneksizdir.
          * 
          * 2.2 -Convert 
          * Herhangi bir tipi herhangi bir tipe dönüştürebilir parse'a göre daha yetenekli fakat daha performanssızdır
          * 
          * 
          * */

            //implictly cast örneği
            //short a = 350;
            //int b = a;

            //explictly cast örneği
            //int sayi = 300;
            //byte c = (byte)sayi;
            //Console.Write(c);
            //Console.ReadLine();


            //cast yöntemi yetersiz kalıyor
            /*
            string deger = "5";
            int sayi2 = (int) deger;
            */

            //Parse Örneği
            //string deger2 = "10";
            //short sayi3 = short.Parse(deger2);

            //convert örneği
            //decimal sayi4 = 10.85m; //m yazınca decimal değer olmuş oluyor bu sayı veya decimal sayi4=(decimal)10.85 de yapabiliriz yani cast işlemi.
            //int sayi5 = Convert.ToInt32(sayi4);//int 32 yapınca geriye int döner int 64 yapınca long döner int 16 yapınca geriye short döner.(sayı5 in değeri 10 olur.)

            //Kullanıcının iki sayı girmesi sağlanmalı




        }
    }
}
