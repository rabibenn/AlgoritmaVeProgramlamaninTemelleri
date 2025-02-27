using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("rabi");
            //Console.Write("rabi");
            //Console.Write(3 + ". Sayıyı Giriniz:");

            /*int a = 6;
            Console.Write(a + "'nın karesi = " + a * a);*/

            /*Console.WriteLine("Merhaba\nTürkiye");
            Console.WriteLine("C:\\My Documents\\");
            Console.WriteLine("Bana \"yok\" dedi.");
            Console.WriteLine("Kayıtlı Marka\u00AE");*/

            /*int a, b = 9;
            double c = 2.5, d;
            a = 15;
            d = c * 3;
            Console.WriteLine(d);
            a = b + 9;
            Console.WriteLine(a);*/

            /*char x = 'h';
            string y = "rabiyim";
            Console.WriteLine(x);
            Console.WriteLine(y);*/

            /*string s, adi;
            char k;
            s = "rabi";
            adi = s;
            k = 'a';
            Console.WriteLine(s);
            Console.WriteLine(adi);
            Console.WriteLine(k);*/

            /*Özel Durumlar
            Console.WriteLine("C:\\Kitap\\Makale");
            Console.WriteLine(@"\Kitap\Makale");
            Console.WriteLine(@"Bana 'gel' dedi.");*/

            bool cinsiyet;
            cinsiyet = false;
            if (cinsiyet == true)
                Console.WriteLine("Erkek");
            else
                Console.WriteLine("Kadın");

            /*int a, b = 350;
            byte k = 0;
            double f;
            b = k;
            k = b;
            a = f;
            f = a;
            k = 255;
            f = 1500;*/

            /*byte a = 100;
            int b = 500;
            double d = 2.5;
            b = a;
            a = b;
            d = b;
            b = d;*/

            /*byte a = 100;
            int b = 500;
            long c = 200;
            double d = 2.5;
            a = (byte)b;
            b = (int)c;
            b = c;
            c = b;
            b= (int)d;*/

            /*byte b = 5;
            string s = Convert.ToString(b);
            Console.WriteLine(s);*/

            /*string s = "50";
           byte a = Convert.ToByte(s);
           short b = Convert.ToByte(s);
           ushort c = Convert.ToByte(s);
           int d = Convert.ToInt32(s);
           long e = Convert.ToInt64(s);
           float f = Convert.ToSingle(s);
           double g = Convert.ToDouble(s);*/

            /*byte b;
            b = byte.MaxValue;
            Console.WriteLine(b);   
            b = byte.MinValue;
            Console.WriteLine(b);*/



            Console.ReadKey();
            //Ekranı dondurur. (ReadLine ile yazılırsa veri girişi yapılıp Enter'a basıldığında kapanır.ReadKey ile yazılırsa ise herhangi bir tuşa basıldığında ekran kapanır.)

        }
    }
}
