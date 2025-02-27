using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            //Sabit döngüler
            //  - for
            //  - foreach
            //Şartlı döngüler
            //  - while
            //  - do - while


            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (;;)
            //{
            //    Console.WriteLine("rabi");
            //}
            //Sonsuz döngüye sokar.



            //for (int i = 0; i <= 10; i++)
            //{
            //    for(int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine(i+"*"+j+"="+(i*j));
            //    }
            //}


            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (char i = 'z'; i >= 'a'; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("Merhaba Dünya!");
            //}



            //double sonuc = 0 , n = 0;

            //Console.WriteLine("Öğrenci sayısını giriniz:");
            //double osayi = Convert.ToDouble(Console.ReadLine());

            //for (int i = 1; i <= osayi; i++)
            //{
            //    Console.WriteLine(i  + ". Öğrencinin notunu giriniz:");
            //    n = Convert.ToDouble(Console.ReadLine());
            //    sonuc += n;

            //}

            //double ortalama = 0;
            //ortalama = sonuc / osayi;
            //Console.WriteLine("Notların ortalaması: " + ortalama );


            //ForEach Döngüsü 
            //Sıralı olmayan değerlerin alınmasını sağlar.

            //double[] A = { 4, 9, 145, 744, 14, 3.5 };
            //double toplam = 0;


            //foreach (double U in A) 
            //{
            //    toplam += U;  
            //}

            //Console.WriteLine("Toplam = " + toplam);

            //Şartlı Döngüler
            //Belirli bir şart sağlanana kadar devam eden döngülerdir.

            //İkiye ayrılır.
            //    Şartı başta olan (while)
            //       Eğer baştaki şart tutmazsa program hiç döngüye girmez.
            //       Şart ve şart değişkeni önemli iki bileşenidir.
            //       Şartlar doğal ve manuel olarak  iki şekilde bozulabilir.

            //int a = 0;
            //while (a < 10)
            //{
            //    a++;
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("Döngü dışı");

            //int a = 0, b = 0, toplam = 0;
            //while (b == 0) 
            //{
            //    a++;
            //    toplam = toplam + a;
            //    if (a == 10)
            //    {
            //        b = 2;
            //    } 
            //}

            //Console.WriteLine("Toplam: " + toplam);

            //    Şartı sonda olan (do-while)
            //       Şart ve şart değişkeni önemli iki bileşenidir.
            //       

            //int a = 0;

            //do
            //{
            //    a++;
            //    Console.WriteLine(a);

            //} while (a < 5);
            //Console.WriteLine("Döngü dışı");

            //int a = 0, b = 0, toplam = 0;
            //do 
            //{
            //    a++;
            //    toplam = toplam + a;
            //    if (a == 10)
            //    {
            //        b = 2;
            //    }

            //} while (b == 0);
            //Console.WriteLine("Toplam: " + toplam);



            //Döngü Denetleme

            //int kontrol = 0;
            //Console.Write("Sayı Giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi == 1 || sayi == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı asal değildir");
            //}
            //else 
            //{
            //    for (int i = 2; i < sayi; i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            kontrol++;
            //            break;
            //        }
            //    }
            //    if (kontrol != 0)
            //    {
            //        Console.WriteLine("Girdiğiniz sayı asal değildir.");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Girdiğiniz sayı asaldır");
            //    }
            //}


            int sonuc = 0;
            Console.WriteLine("Bir sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

                sonuc += i;
            }

            Console.WriteLine("Bu iki sayının arasındaki tek sayıların toplamı: " + sonuc);



        }
    }
}
