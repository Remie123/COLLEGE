using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atsiskaitymas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] pazymiai =
            {
                {10, 0, 8, 8 },
                {10, 10, 10, 10 },
                {4, 0, 0, 3 },
                {10, 10, 10, 10 },
                {9, 0, 9 , 9 },
                {8, 8, 8, 8},
                {5, 0, 0 , 3 },
            };
            SpausdintiMatrica(pazymiai);
            double[] vidurkisMasyvas = MokiniuVidurkiai(pazymiai);
            Console.WriteLine($"I egzamina bent po 1 karta neatvyko"); //neveikia kazkodel nespejau 
            KiekNeatvyko(pazymiai);
            Console.WriteLine($"Neislaikyta buvo {KiekNeislaikyta(pazymiai)} egzaminai");
            Console.WriteLine("Mokiniu vidurkiai\n");
            double[] Vidurkiai = MokiniuVidurkiai(pazymiai);
            double max = GeriausiasVidurkis(Vidurkiai);
            SpausdintiMasyva(vidurkisMasyvas);
            BendrasVidurkis(Vidurkiai);

        }
        static int KiekNeatvyko(int[,] pazymiai)
        {
            int neatejo = 0;

            for (int i = 0; i < pazymiai.GetLength(0); i++)
            {
                for (int j = 0; j < pazymiai.GetLength(1); j++)
                {
                    if (pazymiai[i, j] == 0)
                    {
                        neatejo++;
                        break;
                    }
                }
            }
            return neatejo;
        }
        static void SpausdintiMatrica(int[,] pazymiai)
        {
            for (int i = 0; i < pazymiai.GetLength(0); i++)
            {
                for (int j = 0; j < pazymiai.GetLength(1); j++)
                {
                    Console.Write(pazymiai[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void SpausdintiMasyva(double[] vidurkiai)
        {
            for (int i = 0; i < vidurkiai.Length; i++)
            {
                Console.Write("{0, 4:f}", vidurkiai[i] + "\t");
            }
        }
        static double[] MokiniuVidurkiai(int[,] pazymiai)
        {
            double[] vidurkisMasyvas = new double[pazymiai.GetLength(0)];
            double vidurkis;
            for (int i = 0; i < pazymiai.GetLength(0); i++)
            {
                double suma = 0;
                for (int j = 0; j < pazymiai.GetLength(1); j++)
                {
                    suma += pazymiai[i, j];
                }
                vidurkis = (double)suma / pazymiai.GetLength(1);
                vidurkisMasyvas[i] = vidurkis;
            }
            return vidurkisMasyvas;
        }
        static int KiekNeislaikyta(int[,] pazymiai)
        {
            int neislaikyti = 0;
            for (int i = 0; i < pazymiai.GetLength(1); i++)
            {
                for (int j = 0; j < pazymiai.GetLength(0); j++)
                {
                    if (pazymiai[j, i] <= 4)
                    {
                        neislaikyti++;
                        break;
                    }
                }
            }
            return neislaikyti;
        }
        static double GeriausiasVidurkis(double[] vidurkis)
        {
            double max = 0;
            for (int i = 0; i < vidurkis.Length; i++)
            {
                if (vidurkis[i] >= max) // nezinau ar >= ar <= bet tikekimes kad veiks
                {
                    max = vidurkis[i];
                }
            }
            return max;
        }
        static double BendrasVidurkis(double[] vidurkis)
        {
            double temp = 0;
            for (int i = 0; i < vidurkis.Length; i++)
            {
                temp += vidurkis[i];
            }
            double bendrasVidurkis = temp / vidurkis.Length; // temp uztruko 20 min kol atsimint 
            return bendrasVidurkis;
        }

    }
}