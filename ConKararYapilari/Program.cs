using System;

namespace ConKararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karar Yapılari
             * 1-if else
             * Yazımı
             * if(koşul){
             * 
             * }
             * else if(koşul)
             * {
             * 
             * }
             * else if(koşul)
             * {
             * 
             * }
             * 
             * else{
             * 
             * }
             * 
             * 
             */

            string kullaniciAdi = "Admin";
            string parola = "123";

            Console.Write("Kullanici Adı: ");
            string ka = Console.ReadLine();
            Console.Write("Parola:");
            string prl = Console.ReadLine();

            if (ka == kullaniciAdi && prl == parola)
            {
                Console.Write("Hoşgeldin {0} ", ka);

            }
            else
            {
                Console.Write("Kullanıcı Adı veya Parola Yanlış");
            }
            Console.Clear();//consolu temizler


            //Giirilen iki sayıdan hangisinin büyük hangisinin küçük olduğunu söyleyen uygulamayı yazınız


            Console.Write("1.sayıyı giriniz");
            int s1 = Convert.ToInt32(Console.ReadLine());// Console.Readline string döndürüyor
            Console.Write("2.sayıyı giriiniz");
            int s2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
