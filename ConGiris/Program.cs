//bunlar kütüphanedir.
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConGiris //namespacede bir kütüphanedir.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consoleda bip sesi çıkartır.
            /* Console.Beep(500,2000);   birden fazla 
             * satır yazmak için kullanılır */

            Console.WriteLine("merhaba dünya");//writeline bir alt satıra atar.
            Console.ReadLine();//consolun kapanmasını önler 
        }
    }
}
