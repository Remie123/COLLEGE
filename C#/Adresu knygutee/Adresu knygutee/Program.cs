using Adresu_knygutee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresu_knygutee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresatas adresatas1 = new Adresatas ("Petras","Algoritmas", "Vilnius", "Pergales", 42, 1, 867784483 );
            Adresatas adresatas2 = new Adresatas ("Kajus", "Sakalas","Vilnius", "Saules", 23, 4, 863752783 );
            Adresatas adresatas3 = new Adresatas ("Vladimir","Garbasan", "Kaunas","Draugystes",  55, 8, 863947324 );
            
            List<Adresatas> list = new List<Adresatas>();
            list.Add(adresatas1);
            list.Add(adresatas2);
            list.Add(adresatas3);
            PrintList(list);
            //Salinti(list, naujas);
            //Paieska(list, naujas);
        }

        static void PrintList(List<Adresatas> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static List<Adresatas> Salinti(List<Adresatas> list, Adresatas adresatas)
        {
            List<Adresatas> naujas = new List<Adresatas>();

            for (int i = 0; i < list.Count; i++)
                if (adresatas.Pavarde.StartsWith("A"))
                    naujas.Remove(adresatas);
                else
                    naujas.Add(adresatas);

            return naujas;


        }
        static int Paieska(List<Adresatas> list, string miestas)
        {
            int kiekis = list.Count(elem => elem.Miestas.Equals(miestas));

                return kiekis;
        }
    }
}










