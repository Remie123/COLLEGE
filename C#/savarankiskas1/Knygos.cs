using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas
{
    internal class Knygos
    {
        public string Pavadinimas { get; private set; }

        public int Kaina { get; private set; }

        public int PuslapiuSkaicius { get; private set; }

        public string Autorius { get; private set; }

        public Knygos(string pavadinimass, int kaina, int puslapiuSkaicius, string autorius)
        {
            Pavadinimas = pavadinimass;
            Kaina = kaina;
            PuslapiuSkaicius = puslapiuSkaicius;
            Autorius = autorius;
        }
        public static Rinktine SkaitytiKnygas(string failoVardas)
        {
            List<Knygos> knyga = new List<Knygos>();

            using (StreamReader failas = new StreamReader(failoVardas))
            {
                string eilute;
                string pavadinimas = failas.ReadLine();

                while ((eilute = failas.ReadLine()) != null)
                {
                    string[] eilutesDalys = eilute.Split(';');
                    string autorius = eilutesDalys[0];
                    string pavadinimass = eilutesDalys[1];
                    int kaina = Convert.ToInt32(eilutesDalys[2]);
                    int puslapiuSkaicius = Convert.ToInt32(eilutesDalys[3]);

                    Knygos knygos = new Knygos(pavadinimass, kaina, puslapiuSkaicius, autorius);
                    
                    knyga.Add(knygos);
                }
                Rinktine rinktine = new Rinktine(pavadinimas, knyga);

                return rinktine;
            }
        }
        private static double BrangiausiosKnygos(List<Knygos> knygos)
        {
            double BrangiausiaKnyga = knygos[0].Kaina;
            foreach (Knygos knyga in knygos)
            {
                if (knyga.Kaina.CompareTo(BrangiausiaKnyga) > 0)
                {
                    BrangiausiaKnyga = knyga.Kaina;
                }
            }
            return BrangiausiaKnyga;
        }
        public static void VisosBrangiausiosKnygos(List<Knygos> knygos, List<Knygos> newList)
        {
            double BrangiausiosKnyga = BrangiausiosKnygos(knygos);
            foreach (Knygos knyga in knygos)
            {
                if (BrangiausiosKnyga == knyga.Kaina)
                    newList.Add(knyga);
            }
        }
        public static void SpausdintiAutoriu(string CFr, List<string> autoriai)
        {
            string line = new string(c: '-', 80);
            using (var file = new StreamWriter(File.Open(CFr, FileMode.Append),
             Encoding.UTF8))
            {
                file.WriteLine(line);
                file.WriteLine("Autoriu sarasas be pasikartojimo");
                file.WriteLine(line);
                foreach ( string autorius in autoriai)
                {
                    file.WriteLine(autorius);
                }
                file.WriteLine(line);
            }
        }
    }
}
