﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [0,9] sayilari yaz


            //int sayac = 0;
            //while (sayac < 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            //    Console.ReadKey();
            #endregion


            #region [0,n] sayilari toplayan

            //int n = 1000;
            //int sayac = 0;
            //int toplam = 0;
            //while (sayac <= n)
            //{
            //    toplam = toplam + sayac;
            //     sayac++;

            //}
            //Console.WriteLine("sonuc=" + toplam);

            //Console.ReadKey();
            #endregion

            #region girilen sayının faktöriyeli

            Console.WriteLine("Sayiyi Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());


            int sayac = 1;
            int fakto = 1;
            while (sayac <= sayi)
            {
                fakto = fakto * sayac;
                sayac++;
            }
            Console.WriteLine("sonuc2= " + fakto);
            Console.ReadKey();
            #endregion



        }
    }
}
