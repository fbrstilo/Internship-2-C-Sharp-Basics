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
                                break;
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
                        Console.Clear();
                        InputError();
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
                        if (kvp.Value.Contains(imePjesme))
                        {
                            flag3 = 1;
                            Console.WriteLine("Redni broj te pjesme je " + kvp.Key);                        }
                    }
                    if (flag3 == 0)
                    {
                        Console.Clear();
                        InputError();
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
                                break;
                            }
                        }
                        if (flag4 == 0)
                        {
                            listaPjesama[listaPjesama.Count + 1] = novaPjesma;
                            Return();
                            goto Unos;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ta pjesma je vec na listi. Pokusajte ponovno.");
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
                        ConfirmError();
                        goto Check4;
                    }
                case 5:
                    Console.Clear();
                Case5:
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        Console.WriteLine(kvp.Key + " " + kvp.Value);
                    }
                    Console.WriteLine("\nUnesite redni broj pjesme koju zelite obrisati:           (0 za povratak)");
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
                            var tempDict5 = new Dictionary<int, string>();
                            foreach (KeyValuePair<int, string> kvp in listaPjesama)
                            {
                                if (kvp.Key < brojBrisanje)
                                {
                                    tempDict5[kvp.Key] = kvp.Value;
                                }
                                else if (kvp.Key > brojBrisanje)
                                {
                                    tempDict5[kvp.Key - 1] = kvp.Value;
                                }
                            }
                            listaPjesama = tempDict5;
                        }
                        else
                        {
                            Console.Clear();
                            InputError();
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
                        ConfirmError();
                        goto Check5;
                    }
                case 6:
                    Console.Clear();
                Case6:
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        Console.WriteLine(kvp.Key + " " + kvp.Value);
                    }
                    Console.WriteLine("\nUnesite ime pjesme koju zelite obrisati:           (0 za povratak)");
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
                            if (kvp6.Value.Contains(imeBrisanje))
                            {
                                broj6 = kvp6.Key;
                            }
                        }
                        if (broj6 > 0)
                        {
                            var tempDict6 = new Dictionary<int, string>();
                            foreach (KeyValuePair<int, string> kvp in listaPjesama)
                            {
                                if (kvp.Key < broj6)
                                {
                                    tempDict6[kvp.Key] = kvp.Value;
                                }
                                else if (kvp.Key > broj6)
                                {
                                    tempDict6[kvp.Key - 1] = kvp.Value;
                                }
                            }
                            listaPjesama = tempDict6;
                        }
                        else
                        {
                            Console.Clear();
                            InputError();
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
                        ConfirmError();
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
                        ConfirmError();
                        goto Check7;
                    }
                case 8:
                    Console.Clear();
                    Case8:
                    foreach (KeyValuePair<int, string> kvp in listaPjesama)
                    {
                        Console.WriteLine(kvp.Key + " " + kvp.Value);
                    }
                    Console.WriteLine("\nUnesite redni broj pjesme koju zelite urediti.           (0 za povratak)");
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
                                Console.Clear();
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
                            Console.Clear();
                            InputError();
                            goto Check8;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        InputError();
                        goto Case8;
                    }
                case 9:
                Case9:
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
                    }
                    Console.WriteLine("\nKoju pjesmu zelite premjestiti?(1-" + listaPjesama.Count + ")           (0 za povratak)");
                    var start9 = int.Parse(Console.ReadLine());
                    if (start9 == 0)
                    {
                        Console.Clear();
                        goto Unos;
                    }
                    else if (start9 > 0 && start9 <= listaPjesama.Count)
                    {
                        Console.WriteLine("Na koje mjesto zelite premjestiti tu pjesmu?(1-" + listaPjesama.Count + ")           (0 za povratak)");
                        var end9 = int.Parse(Console.ReadLine());
                        if (end9 == 0)
                        {
                            goto Case9;
                        }
                        else if (end9 > 0 && end9 <= listaPjesama.Count)
                        {
                            Check9:
                            Console.WriteLine("Zelite li nastaviti?  (y/n)");
                            var prekid9 = char.Parse(Console.ReadLine());
                            if (prekid9 == 'y')
                            {
                                var songName = "";
                                foreach(KeyValuePair<int, string> kvp in listaPjesama)
                                {
                                    if (kvp.Key == start9)
                                    {
                                        songName = kvp.Value;
                                    }
                                }
                                (int, string) movingSong = (end9, songName);
                                var tempDict91 = new Dictionary<int, string>();
                                var tempDict92 = new Dictionary<int, string>();
                                foreach (KeyValuePair<int, string> kvp in listaPjesama)
                                {
                                    if (kvp.Key < start9)
                                    {
                                        tempDict91.Add(kvp.Key, kvp.Value);
                                    }
                                    else if (kvp.Key > start9)
                                    {
                                        tempDict91.Add(kvp.Key - 1, kvp.Value);
                                    }
                                }
                                foreach (KeyValuePair<int, string> kvp in tempDict91)
                                {
                                    if (kvp.Key < end9)
                                    {
                                        tempDict92.Add(kvp.Key, kvp.Value);
                                    }
                                }
                                tempDict92.Add(movingSong.Item1, movingSong.Item2);
                                foreach (KeyValuePair<int, string> kvp in tempDict91)
                                {
                                    if (kvp.Key >= end9)
                                    {
                                        tempDict92.Add(kvp.Key + 1, kvp.Value);
                                    }
                                }
                                listaPjesama = tempDict92;
                            }
                            else if (prekid9 == 'n')
                            {
                                Console.Clear();
                                goto Case9;
                            }
                            else
                            {
                                Console.Clear();
                                InputError();
                                goto Check9;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            InputError();
                            goto Case9;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        InputError();
                        goto Case9;
                    }
                    Return();
                    goto Unos;
                default:
                    Console.Clear();
                    InputError();
                    goto Unos;
            }
        }
        static void Return()
        {
            Console.Write("\nZa povratak na pocetnu stranicu pritisnite enter");
            Console.ReadLine();
            Console.Clear();
        }
        static void ConfirmError()
        {
            Console.WriteLine("Krivi unos. Potvrdite svoju odluku");
        }
        static void InputError()
        {
            Console.WriteLine("Krivi unos. Pokusajte ponovno");
        }
    }
}
