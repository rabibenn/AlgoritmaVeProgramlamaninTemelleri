using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞartİfadeleriÖrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz:");

            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 100 && a < 200)
            {
                Console.WriteLine("Sayınız 100 ve 200 arasında bir sayıdır.");
            }

            else if (a == 100)
            {
                Console.WriteLine("Sayınız 100'e eşit.");
            }

            else if (a == 200)
            {
                Console.WriteLine("Sayınız 200'e eşit.");
            }

            else if (a < 100)
            {
                Console.WriteLine("Sayınız 100'den küçük bir sayıdır.");
            }

            else
            {
                Console.WriteLine("Sayınız 200'den büyük bir sayıdır.");
            }





            //int not;
            //Console.WriteLine("Bir not giriniz:");
            //not = Convert.ToInt32(Console.ReadLine());

            //if (not > 100)
            //    Console.WriteLine("Puanlandırma sistemimiz 100 üzerinden olduğu için daha büyük bir not giremezsiniz.");

            //else if (not >= 75)
            //    Console.WriteLine(not + " Çok iyi.");

            //else if (not >= 50)
            //    Console.WriteLine(not + " İyi.");

            //else
            //    Console.WriteLine(not + " Daha fazla çalışmalı.");




            //double quiz;
            //Console.WriteLine("Quizden alınan notu giriniz:");
            //quiz = Convert.ToDouble(Console.ReadLine());

            //double sinav;
            //Console.WriteLine("Sınavdan alınan notu giriniz:");
            //sinav = Convert.ToDouble(Console.ReadLine());

            //double vize;
            //Console.WriteLine("Vizeden alınan notu giriniz:");
            //vize = Convert.ToDouble(Console.ReadLine());

            //double final;
            //Console.WriteLine("Finalden alınan notu giriniz:");
            //final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (quiz * 0.1 + sinav * 0.2 + vize * 0.3 + final * 0.4);

            //Console.WriteLine("Quizden alınan not: " + quiz);
            //Console.WriteLine("Sınavdan alınan not: " + sinav);
            //Console.WriteLine("Vizeden alınan not: " + vize);
            //Console.WriteLine("Finalden alınan not: " + final);
            //Console.WriteLine("Ortalamanız: " + ortalama);

            //if (ortalama >= 85)
            //    Console.WriteLine("Harf Notunuz: AA");

            //else if (ortalama >= 75)
            //    Console.WriteLine("Harf Notunuz: BA");

            //else if (ortalama >= 70)
            //    Console.WriteLine("Harf Notunuz: BB");

            //else if (ortalama >= 65)
            //    Console.WriteLine("Harf Notunuz: CB");

            //else if (ortalama >= 60)
            //    Console.WriteLine("Harf Notunuz: CC");

            //else if (ortalama >= 50)
            //    Console.WriteLine("Harf Notunuz: DC");

            //else if (ortalama >= 40)
            //    Console.WriteLine("Harf Notunuz: DD");

            ////else if (ortalama < 0)
            ////    Console.WriteLine("0'ın altında not girişi yapılamaz.");

            ////else if (ortalama > 100)
            ////    Console.WriteLine("100'ün üzerinde not girişi yapılamaz.");

            //else
            //    Console.WriteLine("Harf Notunuz: FF");





            //double sayi1;
            //Console.WriteLine("1. sayıyı giriniz.");
            //sayi1 = Convert.ToDouble(Console.ReadLine());

            //double sayi2;
            //Console.WriteLine("2. sayıyı giriniz.");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //double sayi3;
            //Console.WriteLine("3. sayıyı giriniz.");
            //sayi3 = Convert.ToDouble(Console.ReadLine());

            //if (sayi1 > sayi2 && sayi1 > sayi3)
            //    Console.WriteLine("En büyük sayı: " + sayi1);

            //else if (sayi2 > sayi3 && sayi2 > sayi1)
            //    Console.WriteLine("En büyük sayı: " + sayi2);

            //else if (sayi3 > sayi2 && sayi3 > sayi1)
            //    Console.WriteLine("En büyük sayı: " + sayi3);

            //else if (sayi1 == sayi2 && sayi1 == sayi3 && sayi2 == sayi3)
            //    Console.WriteLine("Girdiğiniz sayıların hepsi eşit.");

            //else
            //    Console.WriteLine("BU KADAR BİLİYORUM...");





            //Console.WriteLine("Lütfen bir gün giriniz:");
            //string gun = Console.ReadLine().ToLower();

            //switch (gun)
            //{
            //    case "pazartesi": Console.WriteLine(gun + " Hafta içi"); break;
            //    case "salı": Console.WriteLine(gun + " Hafta içi"); break;
            //    case "çarşamba": Console.WriteLine(gun + " Hafta içi"); break;
            //    case "perşembe": Console.WriteLine(gun + " Hafta içi"); break;
            //    case "cuma": Console.WriteLine(gun + " Hafta içi"); break;
            //    case "cumartesi": Console.WriteLine(gun + " Hafta sonu"); break;
            //    case "pazar": Console.WriteLine(gun + " Hafta sonu"); break;

            //    default: Console.WriteLine(gun + " Böyle bir gün yok! hafta içi veya hafta sonu olduğu bulunamaz."); break;
            //}



            //double sayi1;
            //Console.WriteLine("1. sayıyı giriniz.");
            //sayi1 = Convert.ToDouble(Console.ReadLine());

            //double sayi2;
            //Console.WriteLine("2. sayıyı giriniz.");
            //sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen işlem türünü giriniz.");
            //Console.WriteLine("toplama = 1, çıkarma = 2, çarpma = 3, bölme = 4");
            //int islem = Int32.Parse(Console.ReadLine());

            //switch(islem)
            //{
            //    case 1: Console.WriteLine(sayi1 + sayi2); break;
            //    case 2: Console.WriteLine(sayi1 - sayi2); break;
            //    case 3: Console.WriteLine(sayi1 * sayi2); break;
            //    case 4: Console.WriteLine(sayi1 / sayi2); break;
            //    default: Console.WriteLine("Hata! Böyle bir işlem bulunamadı."); break;
            //}
        }
    }
}
