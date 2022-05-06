using System;

namespace ConTakimOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Takım Oyunu

            //1.adım:Kullanıcıya kaç isim gireceği sorulup girilen adet boyutunda dizi tanımlanacak.
            //  girilen adet çift sayı olmak zorundadır.
            int adet = 0;
            string[] isimler = new string[0];
            do
            {
                Console.Write("Kaç isim girilecek: ");
                adet = Convert.ToInt32(Console.ReadLine());
                if (adet % 2 == 0)//çift sayı ise
                {
                    isimler = new string[adet];//isimler dizisini yeniden boyutlandır.
                }
                else
                {
                    Console.WriteLine("Lütfen çift sayı giriniz");
                }


            } while (adet % 2 != 0);

            //2.adım:kullanıcının belirtmiş olduğu adet kadar oyuncu ismi girmesini sağlamak ve bu isimleri diziye atmak
            //ancak bir isim dizidee bir kez bulunabilmelidir.

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine("{0}.ismi giriniz:", i + 1);
                string isim = Console.ReadLine();
                if (isimler.Contains(isim) == true)//isimler dizisinde isim içeriyorsa
                {
                    i--;//bi daha  işlem yapmak için 
                }
                else
                {
                    isimler[i] = isim;//diziye ismi atadık.
                }

            }
            //3.adım :İki tane takım oluşturulmalı ve oyuncular eşit sayılarda rastgele bir şekilde takımlara dağıtılmalıdır.

            //Kural 1:bir oyuncu sadece bir takımda bulunabilir
            //kural 2:bir oyuncu bir takımda bir kez bulunabilir.




        }
    }
}
