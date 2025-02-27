using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vücut kitle indeksi hesaplama

            double kilo;
            Console.WriteLine("Kilonuzu kg cinsinden giriniz:");
            kilo = Convert.ToDouble(Console.ReadLine());

            double boy;
            Console.WriteLine("Boyunuzu m cinsinden giriniz:");
            boy = Convert.ToDouble(Console.ReadLine());


            double idealkilo = (kilo / (boy * boy));

            if (idealkilo <= 18.49)
                Console.WriteLine("İdeal kilonun altındasınız.");

            else if (idealkilo <= 24.99)
                Console.WriteLine("İdeal kilodasınız");

            else if (idealkilo <= 29.99)
                Console.WriteLine("İdeal kilonun üzerindesiniz.");

            else
                Console.WriteLine("İdeal kilonun çok üzerindesiniz.");







            Console.ReadKey();
        }
    }
}
