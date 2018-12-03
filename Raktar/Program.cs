using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static void Torles(ref string[] file)
        {
            Console.Clear();
            Console.Write("Adja meg a termék nevét: ");
            string termekNev = Console.ReadLine();
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Contains(termekNev))
                {
                    file[i] = "";

                }



            }
            StreamWriter torleselemek = new StreamWriter("adatok.csv");
            for (int i = 0; i < file.Length; i++)
            {
                torleselemek.WriteLine(file[i]);
            }

            torleselemek.Close();
        }

        static void Modositas(ref string[] file)
        {
            Console.Clear();
            Console.Write("Kérem a termék azonosítóját: ");
            string azon = Console.ReadLine();
            bool hibasAdat = true;
            StreamWriter kiIras = new StreamWriter("adatok.csv");
            for (int i = 0; i < file.Length; i++)
            {
                string[] splitelt = file[i].Split(';');
                if (splitelt[0]==azon)
                {
                    hibasAdat = false;
                    Console.Clear();
                    Console.WriteLine("A termék adatai: " + splitelt[0] + " " + splitelt[1] + " " + splitelt[2]);
                    Console.Write("Mit szeretne módosítani?");
                    Console.WriteLine();
                    Console.WriteLine("1. Név");
                    Console.WriteLine("2. Mennyiség");
                    int modositasSzama = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (modositasSzama)
                    {
                        case 1:
                            Console.Write("Adja meg a termék új nevét: ");
                            string ujNev = Console.ReadLine();
                            file[i] = splitelt[0] + ";" + ujNev + ";" + splitelt[2];
                            for (int j = 0; j < file.Length; j++)
                            {
                                kiIras.WriteLine(file[j]);
                            }
                            kiIras.Close();
                            break;
                        case 2:
                            //Ezt csináld meg.
                            Console.Write("Adja meg a termék új mennyiségét: ");
                            string ujMennyiseg = Console.ReadLine();
                            file[i] = splitelt[0] + ";" + splitelt[1] + ";" + ujMennyiseg;
                            for (int j = 0; j < file.Length; j++)
                            {
                                kiIras.WriteLine(file[j]);
                            }
                            kiIras.Close();



                            break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Hibás adat!");
                            Console.WriteLine("(Nyomjon meg bármilyen gombot a visszatéréshez)");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
            if (hibasAdat)
            {
                Console.Clear();
                Console.WriteLine("Nincs ilyen azonosítóval ellátott termék!");
                Console.WriteLine("(Nyomjon meg bármilyen gombot a visszatéréshez)");
                Console.ReadKey();
            }
        }

        static void Letrehozas(ref string[] file)
        {
            Console.Clear();
            Console.Write("Kérem adja meg a termék azonosítóját: ");
            string id = Console.ReadLine();
            Console.Clear();
            Console.Write("Kérem adja meg a termék nevét: ");
            string nev = Console.ReadLine();
            Console.Clear();
            Console.Write("Kérem adja meg a termék darabszámát: ");
            string darab = Console.ReadLine();

            File.AppendAllLines("adatok.csv", new[] { id + ";" + nev + ";" + darab });
        }




        static void Listázás(ref string[] file)

        {
            Console.Clear();
            for (int i = 0; i < file.Length; i++)
            {

                Console.WriteLine(file[i]);

            }
            Console.ReadKey();
        }

        static void Kereses(ref string[] file)
        {
            Console.Clear();
            Console.Write("Kérem írja be a keresendő tárgy nevét: ");
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
            Console.Clear();
            if (File.Exists("adatok.csv"))
            {


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
                        Torles(ref file);
                        break;
                    case 2:
                        Modositas(ref file);
                        break;
                    case 3:
                        Letrehozas(ref file);
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
                        break;
                }
                goto start;
            }
            else
            {
                StreamWriter Letrehozas = new StreamWriter("adatok.csv");
                Letrehozas.WriteLine("345;Tej;512");
                Letrehozas.WriteLine("412;Vaj;0");
                Letrehozas.Close();
                goto start;
            }


        }




    }
}
