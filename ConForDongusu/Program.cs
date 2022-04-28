using System;

namespace ConForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * For döngüsü

            * 
            * 
            */


            int deger = 15;
            for (int sayi = 0; sayi <= 100 && deger == 15; sayi++)
            {

                Console.WriteLine(sayi);

            }


            Console.Clear();




            //Kullanıcının girmiş olduğu sayının faktöriyelini hesaplayan uygulamayı yazınız.

            //1.adım:Kullanıcının sayı girmesini sağlamak ve girilen sayıyı bir değişkende tutmak
            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            int faktor = Convert.ToInt32(Console.ReadLine());
        }
    }
}
