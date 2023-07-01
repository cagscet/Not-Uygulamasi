using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.Write("Sayiyi giriniz : ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //if (sayi == 23) {
            //    Console.Write("sayı doğru");
            // }
            //else
            //{
            //    Console.Write("sayı yanlış");
            // }

            //int mat;
            //Console.Write("Matematikten kaç aldınız : ");
            //mat = Convert.ToInt16(Console.ReadLine());

            //if (mat > 59) {
            //    Console.Write("Dersten geçtiniz ");
            //  }

            //else
            //{
            //    Console.Write("Dersten kaldınız");
            //}

            int say, say1,say2, ort;
            Console.Write("ilk notunuzu giriniz :");
            say = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. notunuzu giriniz :");
            say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. notunuzu giriniz :");
            say2 = Convert.ToInt16(Console.ReadLine());
            ort = (say + say1+say2) / 3;
            Console.Write("Ortalamanız" + " " +ort);
            

            if (ort < 49) {
                Console.Write(" " +"Durum vasat");
             }
            if (ort >= 50 & ort <= 60)
             {
                Console.Write(" " + "durum orta");
             }
            if (ort >= 61 & ort <= 80)
             {
                Console.Write(" " + "dersi iyi derece ile geçtin");
             }
            if (ort >= 81)
            {
                Console.Write(" " + "dersi çok iyi derece ile geçtin");
            }
















            Console.Read();
        }
    }
}
