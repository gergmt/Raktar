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

        static void Listázás(ref string[] file)
        {
            for (int i = 0; i <file.Length ; i++)
            {
                Console.WriteLine(file[i]);
            }
        }

        static void Kereses(ref string[] file)
        { 
                Console.Clear();
                Console.WriteLine("Kérem írja be a keresendő tárgy nevét");
                string targyNev = Console.ReadLine();
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Contains(targyNev))
                {
                    Console.Clear();
                    Console.WriteLine("A tárgy adatai:");
                    Console.WriteLine(file[i]);
                } 
            }
            Console.ReadKey();
          
        }

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Kérem üsse be a parancs kódját");
            Console.WriteLine("1. Törlés");
            Console.WriteLine("2. Módosítás");
            Console.WriteLine("3. Létrehozás");
            Console.WriteLine("4. Keresés");
            Console.WriteLine("5. Listázás");
            int valasztas = int.Parse(Console.ReadLine());
            string[] file = File.ReadAllLines("adatok.csv");


            switch (valasztas)
            {
                case 1:
                    Torles();
                    break;
                case 2:
                    Modositas();
                    break;
                case 3:
                    Letrehozas();
                    break;
                case 4:
                    Kereses(ref file);
                    break;
                case 5:
                    Listázás(ref file);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Hibás adat!");
                    Console.WriteLine("(Nyomjon meg bármilyen gombot a visszatéréshez)");
                    Console.ReadKey();
                    Console.Clear();
                    goto start;
            }

        }




    }
}
