using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalDeğişkenler
{
    internal class Program
    {
        static int numara;
        static void degistir()
        {
            numara = 5;
        }

        static void Main(string[] args)
        {
            numara = 7;
            Console.WriteLine(numara);
            degistir();
            Console.WriteLine(numara);

            Console.ReadKey();

        }
    }
}
