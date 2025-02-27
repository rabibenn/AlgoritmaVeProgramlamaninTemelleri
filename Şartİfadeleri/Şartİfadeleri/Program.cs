
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şartİfadeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-if yapısı
            //-switch yapısı
            //-?: ifadesi


            //İF/ELSE
            //if (Şart 1)
            //{
            //    İşlem A;

            //}

            //else if (Şart 2)
            //{

            //}

            //else
            //{
            //    İşlem B;
            //}


            //ÖRNEK;


            int not;
            not = Convert.ToInt32(Console.ReadLine());

            if (not >= 90)
            {
                Console.WriteLine("A");
            }

            else if (not >= 80)
            {
                Console.WriteLine("B");
            }
            else if (not >= 70)
            {
                Console.WriteLine("C");
            }

            else if (not >= 60)
            {
                Console.WriteLine("D");
            }

            else if (not >= 50)
            {
                Console.WriteLine("E");
            }

            else
            {
                Console.WriteLine("F");
            }





            //SWİTCH/CASE

            //ÖRNEK;

            //switch (sayi)
            //{
            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;

            //    default: Console.WriteLine("Hata!! Böyle bir gün yok.");
            //        break;
            //}





            //?: ifadesi

            //ÖRNEK;


            // is this condition ture? yes:no

            //int a = 100, b;
            //b = (a == 100) ? 40 : 20;
            //Console.WriteLine(b); 


        }
    }
}
