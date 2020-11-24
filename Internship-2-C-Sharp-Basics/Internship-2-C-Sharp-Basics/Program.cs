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
                {1, "Sejo Keydura - Kula od stakla"},
                {2, "MP Thompson - Cavoglave"},
                {3, "Massimo Savage - Yu gi jo"},
                {4, "Dizzee Rascal - Bassline Junkie"},
                {5, "30Zona - JBG"}
            };
            Unos:
            Console.WriteLine("Odaberite akciju:\n1 - Ispis cijele liste\n2 - Ispis imena pjesme unosom pripadajućeg rednog broja\n3 - Ispis rednog broja pjesme unosomm pripadajuceg imena\n4 - Unos nove pjesme\n5 - Brisanje pjesme po rednom broju\n6 - Brisanje pjesme po imenu\n7 - Brisanje cijele liste\n8 - Uredivanje imena pjesme\n9 - Uredivanje rednog broja pjesme\n0 - Izlaz iz aplikacije\n");
            int unos = int.Parse(Console.ReadLine());
            switch (unos)
            {
                case 0:
                    return;
                case 1:
                    Console.Clear();
                    if (listaPjesama.Count == 0)
                    {
                        Console.WriteLine("Lista je prazna.");
                        Return();
                        goto Unos;
                    }
                    else
                    {
                        foreach (KeyValuePair<int, string> kvp in listaPjesama)
                        {
                            Console.WriteLine(kvp.Key + " " + kvp.Value);
                        }
                        Return();
                        goto Unos;
                    }
                case 2:
                    Console.Clear();
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
                        goto Unos;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Pokusajte ponovo.");
                        goto Case2;
                    }
                case 3:
                    Console.Clear();
                    Case3:
                    Console.WriteLine("Upisite zeljenu pjesmu:           (0 za povratak)");
                    var imePjesme = Console.ReadLine();
                    if (imePjesme == "0")
                    {
                        Console.Clear();
                        goto Unos;
                    }
                    int flag3 = 0;
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        if (imePjesme == kvp.Value)
                        {
                            flag3 = 1;
                            Console.WriteLine("Redni broj te pjesme je " + kvp.Key);
                        }
                    }
                    if (flag3 == 0)
                    {
                        Console.WriteLine("Krivi unos. Pokusajte ponovo.");
                        goto Case3;
                    }
                    Return();
                    goto Unos;
                case 4:
                    Console.Clear();
                    Case4:
                    Console.WriteLine("Naziv nove pjesme:           (0 za povratak)");
                    var novaPjesma = Console.ReadLine();
                    if (novaPjesma == "0")
                    {
                        Console.Clear();
                        goto Unos;
                    }
                    Check4:
                    Console.WriteLine("Zelite li nastaviti?  (y/n)");
                    var prekid4 = char.Parse(Console.ReadLine());
                    if (prekid4 == 'y')
                    {
                        var flag4 = 0;
                        foreach (KeyValuePair<int, string> kvp4 in listaPjesama)
                        {
                            if (kvp4.Value == novaPjesma)
                            {
                                flag4 = 1;
                            }
                        }
                        if (flag4 == 0)
                        {
                            var noviBroj = listaPjesama.Count + 1;
                            listaPjesama[noviBroj] = novaPjesma;
                            Return();
                            goto Unos;
                        }
                        else
                        {
                            Console.WriteLine("Ta pjesma je vec na listi. Pokusajte ponovo.");
                            goto Case4;
                        }
                    }
                    else if (prekid4 == 'n')
                    {
                        Console.Clear();
                        goto Case4;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Potvrdite svoju odluku.");
                        goto Check4;
                    }
                case 5:
                    Console.Clear();
                    Case5:
                    Console.WriteLine("Unesite redni broj pjesme koju zelite obrisati:           (0 za povratak)");
                    var brojBrisanje = int.Parse(Console.ReadLine());
                    if (brojBrisanje == 0)
                    {
                        Console.Clear();
                        goto Unos;
                    }
                Check5:
                    Console.WriteLine("Zelite li nastaviti?  (y/n)");
                    var prekid5 = char.Parse(Console.ReadLine());
                    if (prekid5 == 'y')
                    {
                        if (brojBrisanje > 0 && brojBrisanje <= listaPjesama.Count)
                        {
                            var tempDict = new Dictionary<int, string>();
                            foreach (KeyValuePair<int, string> kvp in listaPjesama)
                            {
                                if (kvp.Key < brojBrisanje)
                                {
                                    tempDict[kvp.Key] = kvp.Value;
                                }
                                else if (kvp.Key > brojBrisanje)
                                {
                                    tempDict[kvp.Key - 1] = kvp.Value;
                                }
                            }
                            listaPjesama = tempDict;
                        }
                        else
                        {
                            Console.WriteLine("Krivi unos. Pokusajte ponovno.");
                            goto Case5;
                        }
                        Return();

                        goto Unos;
                    }
                    else if (prekid5 == 'n')
                    {
                        Console.Clear();
                        goto Case5;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Potvrdite svoju odluku.");
                        goto Check5;
                    }
                case 6:
                    Console.Clear();
                Case6:
                    Console.WriteLine("Unesite ime pjesme koju zelite obrisati:           (0 za povratak)");
                    var imeBrisanje = Console.ReadLine();
                    if (imeBrisanje == "0")
                    {
                        Console.Clear();
                        goto Unos;
                    }
                Check6:
                    Console.WriteLine("Zelite li nastaviti?  (y/n)");
                    var prekid6 = char.Parse(Console.ReadLine());
                    if (prekid6 == 'y')
                    {
                        var broj6 = 0;
                        foreach (KeyValuePair<int, string> kvp6 in listaPjesama)
                        {
                            if (kvp6.Value == imeBrisanje)
                            {
                                broj6 = kvp6.Key;
                            }
                        }
                        if (broj6 > 0)
                        {
                            var tempDict = new Dictionary<int, string>();
                            foreach (KeyValuePair<int, string> kvp in listaPjesama)
                            {
                                if (kvp.Key < broj6)
                                {
                                    tempDict[kvp.Key] = kvp.Value;
                                }
                                else if (kvp.Key > broj6)
                                {
                                    tempDict[kvp.Key - 1] = kvp.Value;
                                }
                            }
                            listaPjesama = tempDict;
                        }
                        else
                        {
                            Console.WriteLine("Krivi unos. Pokusajte ponovno.");
                            goto Case6;
                        }
                        Return();
                        goto Unos;
                    }
                    else if (prekid6 == 'n')
                    {
                        Console.Clear();
                        goto Case6;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Potvrdite svoju odluku.");
                        goto Check6;
                    }
                case 7:
                    Case7:
                    Console.Clear();
                    Check7:
                    Console.WriteLine("Zelite li nastaviti? (y/n)");
                    var prekid7 = char.Parse(Console.ReadLine());
                    if (prekid7 == 'y')
                    {
                        listaPjesama.Clear();
                        Console.WriteLine("Lista obrisana.");
                        Return();
                        goto Unos;
                    }
                    else if (prekid7 == 'n')
                    {
                        Console.Clear();
                        goto Case7;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Potvrdite svoju odluku.");
                        goto Check7;
                    }
                case 8:
                    Console.Clear();
                    Case8:
                    Console.WriteLine("Unesite redni broj pjesme koju zelite urediti.           (0 za povratak)");
                    var redniBroj8 = int.Parse(Console.ReadLine());
                    if (redniBroj8 == 0)
                    {
                        Console.Clear();
                        goto Unos;
                    }
                    else if (redniBroj8 > 0 && redniBroj8 <= listaPjesama.Count)
                    {
                        Console.Write("Novo ime pjesme: ");
                        var ime8 = Console.ReadLine();
                        Check8:
                        Console.WriteLine("Zelite li nastaviti?  (y/n)");
                        var prekid8 = char.Parse(Console.ReadLine());
                        if (prekid8 == 'y')
                        {
                            var flag8 = 0;
                            foreach (KeyValuePair<int, string> kvp8 in listaPjesama)
                            {
                                if (kvp8.Value == ime8)
                                {
                                    flag8 = 1;
                                }
                            }
                            if (flag8 == 0)
                            {
                                listaPjesama[redniBroj8] = ime8;
                                Return();
                                goto Unos;
                            }
                            else
                            {
                                Console.WriteLine("Ta pjesma je vec na listi. Pokusajte ponovo.");
                                goto Case8;
                            }
                        }
                        else if (prekid8 == 'n')
                        {
                            Console.Clear();
                            goto Case8;
                        }
                        else
                        {
                            Console.WriteLine("Krivi unos. Potvrdite svoju odluku.");
                            goto Check8;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos. Pokusajte ponovno");
                        goto Case8;
                    }
                case 9:
                    Return();
                    goto Unos;
                default:
                    Console.WriteLine("Krivi unos. Pokusajte ponovno.\n");
                    goto Unos;
            }
        }
        static void Return()
        {
            Console.Write("\nZa povratak na pocetnu stranicu pritisnite enter");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
