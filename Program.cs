﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_basamaği_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            while (sayi > 0)
            {
                sayi /= 10;
                sayac++;
            }
            Console.WriteLine("Girdiginiz Sayı " + sayac + " Basamaklıdır.");

            Console.ReadLine();

            //çok büyük sayı girince hata veriyor örnek 368691368691
        }
    }
}
