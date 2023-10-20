using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresu_knygutee
{
    internal class Adresatas
    {
        public string Vardas { get; set; }

        public string Pavarde { get; set; }

        public string Miestas { get; set; }

        public string Gatve { get; set; }

        public int NamoNumeris { get; set; }

        public int ButoNumeris { get; set; }

        public int TelefonoNumeris { get; set; }



        public override string ToString()
        {
            string eilute;
            eilute = string.Format(format: "Vardas: {0}\nPavarde: {1}\nMiestas: {2}\nGatve: {3}\nNamo Numeris: {4}\nButo Numeris: {5}\nTelefono Numeris: {6}\n", Vardas, Pavarde, Miestas, Gatve, NamoNumeris, ButoNumeris, TelefonoNumeris);

            return eilute;
        }

        public Adresatas(string vardas, string pavarde, string miestas, string gatve, int namoNumeris, int butoNumeris, int telefonoNumeris)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Miestas = miestas;
            Gatve = gatve;
            NamoNumeris = namoNumeris;
            ButoNumeris = butoNumeris;
            TelefonoNumeris = telefonoNumeris;
        }

        //public int CompareTo(Adresatas adresatas)
        // int adresatoVardas = Vardas.CompareTo(preson.Vardas);
        //int adresatoPavarde = Pavarde.CompareTo(person.Pavarde);
        //int adresatoMiestas = Miestas.CompareTo(person.Miestas);
        //if ((adresatoVardas = "Kajus") ||
        // ((adresatoVardas == "Petras") && (adresatoPavarde == "Algoritmas") && (adresatoMiestas == "Vilnius")))
        // return -1;
        //else
        //return 1;
        // NEZINAUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU pasidaviau
    }
}
