﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static void Torles()
        {

        }
        static void Modositas()
        {

        }
        static void Letrehozas()
        {

        }
        static void Kereses(ref string[] file)
        {
            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine("Kérem írja be a keresendő tárgy nevét");
                string targyNev = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem üsse be a parancs kódját");
            Console.WriteLine("1. Törlés");
            Console.WriteLine("2. Módosítás");
            Console.WriteLine("3. Létrehozás");
            Console.WriteLine("4. Keresés");
            int valasztas = int.Parse(Console.ReadLine());
            string[] file = File.ReadAllLines("adatok.csv");


        }




    }
}
