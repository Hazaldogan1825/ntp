﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_buyuk_sayi_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            BuyukSayiBul bs = new BuyukSayiBul();
            int a = 100;
            int b = 50;
            int sonuc = bs.SayiBulucu(a, b);
            Console.WriteLine("Büyük olan sayı : " + sonuc);
            Console.ReadLine();
        }
    }
}
