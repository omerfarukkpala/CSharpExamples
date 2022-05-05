using System;

namespace ConForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Foreach Döngüsü
             * 
             * -üç önemli kuralı vardır.
             * 1-Sadece ileri gider
             * 2-Readonlydir.(Sadece okunabilir.Yani koleksiyon içerisindeki elemana değer ataması yapılamaz)
             * 3-koleksiyon yapısı foreach'in çalışması sırasında değiştirilemez.
             * 
             *  * 
             * -Yazılışı
             * foreach(elemanTipi degiskenIsmi in koleksiyon){
             * 
             * }
             *
             * Döngüler arasında en çok kullanacağımız döngü yapısıdır.
             
             * 
             * */

            char[] karakterler = { 'A', '5', 'f' };
            foreach (char item in karakterler)
            {
                //item = 'i';  değer ataması yapılmaz hata verir.
            }

            Console.Write("Kaç isim girilecek:");
            int adet = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[adet];

        }
    }
}
