using System;
using System.Collections.Generic;

namespace Internship_2_C_Sharp_Basics
{
    class Program
    {
        static void Main()
        {
            var listaPjesama = new Dictionary<int, string>()
            {
                {1, "Pjesma1"},
                {2, "Pjesma2"},
                {3, "Pjesma3"},
                {4, "Pjesma4"},
                {5, "Pjesma5"}
            };
            Unos:
            Console.WriteLine("Odaberite akciju:\n1 - Ispis cijele liste\n2 - Ispis imena pjesme unosom pripadajućeg rednog broja\n3 - Ispis rednog broja pjesme unosomm pripadajuceg imena\n4 - Unos nove pjesme\n5 - Brisanje pjesme po rednom broju\n6 - Brisanje pjesme po imenu\n7 - Brisanje cijele liste\n8 - Uredivanje imena pjesme\n9 - Uredivanje rednog broja pjesme\n0 - Izlaz iz aplikacije\n");
            int unos = int.Parse(Console.ReadLine());
            switch (unos)
            {
                case 0:
                    return;
                case 1:
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        Console.WriteLine(kvp.Key + " " + kvp.Value);
                    }
                    Return();
                    goto Unos;
                    break;
                case 2:
                    Case2:
                    Console.WriteLine("Upisite zeljeni redni broj pjesme:           (0 za povratak)");
                    var redniBroj = int.Parse(Console.ReadLine());
                    if (redniBroj > 0 && redniBroj <= listaPjesama.Count)
                    {
                        foreach (KeyValuePair<int, string> kvp in listaPjesama)
                        {
                            if (redniBroj == kvp.Key)
                            {
                                Console.WriteLine("Pjesma rednog broja " + redniBroj + " je " + kvp.Value);
                            }
                        }
                        Return();
                        goto Unos;
                    }
                    else if (redniBroj == 0)
                    {
                        Console.Clear();
                        Main();
                        goto Unos;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Pokusajte ponovo.");
                        goto Case2;
                    }
                    break;
                case 3:
                Case3:
                    Console.WriteLine("Upisite zeljenu pjesmu:           (0 za povratak)");
                    var imePjesme = Console.ReadLine();
                    if (imePjesme == "0")
                    {
                        Console.Clear();
                        Main();
                    }
                    int flag = 0;
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        if (imePjesme == kvp.Value)
                        {
                            flag = 1;
                            Console.WriteLine("Redni broj te pjesme je " + kvp.Key);
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("Krivi unos. Pokusajte ponovo.");
                        goto Case3;
                    }
                    Return();
                    goto Unos;
                    break;
                case 4:
                    Console.Write("Naziv nove pjesme: ");
                    var novaPjesma = Console.ReadLine();
                    var noviBroj = listaPjesama.Count + 1;
                    listaPjesama[noviBroj] = novaPjesma;
                    Return();
                    goto Unos;
                    break;
                case 5:
                    Return(); 
                    goto Unos;
                    break;
                case 6:
                    Return();
                    goto Unos;
                    break;
                case 7:
                    Return();
                    goto Unos;
                    break;
                case 8:
                    Return();
                    goto Unos;
                    break;
                case 9:
                    Return();
                    goto Unos;
                    break;
                default:
                    Console.WriteLine("Krivi unos. Pokusajte ponovno.\n");
                    goto Unos;
            }
        }
        static void Return()
        {
            Console.Write("Za povratak na pocetnu stranicu pritisnite enter");
            Console.ReadLine();
            Console.Clear();
        }
    }
}