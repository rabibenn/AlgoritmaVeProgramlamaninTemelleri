
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler_Sabitler_VeriGirişi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            //-Aritmatiksel Operatörler(=, +, -, *,/,%, ++(Bir artırma),--(Bir azaltma))

            //int a, b = 100;
            //a = b++;
            //a = ++b;
            //a = --b;
            //a = b--;

            //-Bit Operatörleri(| (Veya), (Ve), ^(XOR(Eşitsizlik), ~()Değil,<< (Sola kaydırma),>> (Sağa kaydırma))

            //-İşlemli Özel Atama Operatörleri(+=,-=,*=,/=,%=,<<=,>>=,|=,=,)


            //int a = 10, b = 100;
            //a += b;
            //Console.WriteLine("a'nın son değeri : " + a);
            //a /= 2;
            //Console.WriteLine("a'nın son değeri : " + a);


            //Console.ReadKey();

            //-Mantıksal Operatörler(==,<,>,<=,>=,!=)


            //Sabitler
            const String s = "Meslek Yüksekokulu";
            const double pi_sayisi = 3.14159265;
            //pi_sayisi = s;
            //Artık değiştirilemez. Bu yüzden hata verir.
            Console.WriteLine(s);
            Console.WriteLine(pi_sayisi);


            //Veri Girişi
            //-Metinsel Veri Girişi(Console.ReadLine)
            string metin = Console.ReadLine();
            Console.WriteLine(metin);


            //-Sayısal Veri Girişi
            int sayi = Int32.Parse(Console.ReadLine());
            Console.WriteLine(sayi);

            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sayi1);








        }
    }
}
