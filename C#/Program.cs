using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atsiskaitymas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mokiniu kiekis?");
            int mokiniuKiekis = Convert.ToInt32(Console.ReadLine());
            int[] pazymiai = DuomenuIvedimas(mokiniuKiekis);
            Spausdinti(pazymiai);
            Console.ReadKey();

        }
        static int[] DuomenuIvedimas(int mokiniuKiekis)
        {
            int[] pazymyniai;
            pazymyniai = new int[mokiniuKiekis];
            for (int i = 0; i < mokiniuKiekis; i++)
            {
                Console.WriteLine("Studento ivertinimai?");

                int pazymiai = Convert.ToInt32(Console.ReadLine());
                pazymyniai[1] = pazymiai;
                if (pazymiai >= 0 && pazymiai <= 10)
                {
                    i++;
                }
                else

                    Console.WriteLine("Ivertinimas turi buti tarp 0 ir 10 ");
                i--;

            }
            return pazymyniai;

        }
        static void Spausdinti(int[] pazymiai)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("I Studentas \tI\t   Ivertinimas \t\t I");
            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.WriteLine(i);
                switch (pazymiai[i])
                {
                    case 10:
                        Console.WriteLine(ZodinisIvertinimas.Puikiai);
                        break;
                    case 9:
                        Console.WriteLine(ZodinisIvertinimas.l_gerai);
                        break;
                    case 8:
                        Console.WriteLine(ZodinisIvertinimas.gerai);
                        break;
                    case 7:
                        Console.WriteLine(ZodinisIvertinimas.vidutiniskai);
                        break;
                    case 6:
                        Console.WriteLine(ZodinisIvertinimas.patenkinamai);
                        break;
                    case 5:
                        Console.WriteLine(ZodinisIvertinimas.silpnai);
                        break;
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                        Console.WriteLine(ZodinisIvertinimas.nepatenkinamai);
                        break;
                    case 0:
                        Console.WriteLine(ZodinisIvertinimas.neatvyko);
                        break;

                }
            }
            int temp;
            for (int i = 0; i < pazymiai.Length - 1; i++)
            {
                for (int j = i + 1; j < pazymiai.Length; j++)
                {
                    if (pazymiai[i] > pazymiai[j])
                    {
                        temp = pazymiai[i];
                        pazymiai[i] = pazymiai[j];
                        pazymiai[j] = temp;
                    }
                }
            }
            Console.WriteLine(value: " Surikiuoti pazymiai");
            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.WriteLine(pazymiai[i]);
            }
        }
        enum ZodinisIvertinimas
        {
            Puikiai,
            l_gerai,
            gerai,
            vidutiniskai,
            patenkinamai,
            silpnai,
            nepatenkinamai,
            neatvyko
        }
       
    }
}
