using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kartai = string.Empty; // empty nes kitaip neveiks kazkodelelodektporemtbe
            string eilute = new string('-', 60);
            Studentas studentas1, studentas2, studentas3; // objektai
            Liftas liftas1;
            studentas1 = new Studentas(19, 172, 80);
            studentas2 = new Studentas(21, 165, 92);
            studentas3 = new Studentas(20, 184, 100);
            liftas1 = new Liftas(500, 5);
            Console.WriteLine("Amzius  \t         Ugis \t         Svoris ");
            Console.WriteLine(eilute);
            SpausdintiStudenta(studentas1);
            SpausdintiStudenta(studentas2);
            SpausdintiStudenta(studentas3);
            Console.WriteLine(eilute);

            DidziausioAmziausSpausdinimas(studentas1, studentas2, studentas3);

            Console.WriteLine(eilute);

            MaziausioUgioSpausdinimas(studentas1, studentas2, studentas3);

            Console.WriteLine(eilute);
            double visasSvoris = studentas1.ImtiSvori() + studentas2.ImtiSvori() + studentas3.ImtiSvori();
            SpausdintiKiekKartu(kartai);// neveikia nesuprantu irgi?!?!?!?!?!?!?!?!?!??!?!?!?!?
                                        // kodel?!/
                
        }
        static public void SpausdintiStudenta(Studentas studentas)
        {
            Console.WriteLine("{0, -20} {1,10:f2} {2,15:f2}",
                                 studentas.ImtiAmziu(), studentas.ImtiUgi(), studentas.ImtiSvori());
        }
        static private int DidziausiasAmzius(Studentas studentas1, Studentas studentas2, Studentas studentas3)
        {
            return Math.Max(Math.Max(studentas1.ImtiAmziu(), studentas2.ImtiAmziu()), studentas3.ImtiAmziu());
        }
        static public void DidziausioAmziausSpausdinimas(Studentas studentas1, Studentas studentas2, Studentas studentas3)
        {
            int didziausias = DidziausiasAmzius(studentas1, studentas2, studentas3);
            if (didziausias == studentas1.ImtiAmziu())
                Console.WriteLine("Didziausias Amzius yra: {0}", studentas1.ImtiAmziu());
            if (didziausias == studentas2.ImtiAmziu())
                Console.WriteLine("Didziausias Amzius yra: {0}", studentas2.ImtiAmziu());
            if (didziausias == studentas3.ImtiAmziu())
                Console.WriteLine("Didziausias Amzius yra: {0}", studentas3.ImtiAmziu());
        }
        static private double MaziausiasUgis(Studentas studentas1, Studentas studentas2, Studentas studentas3)
        {
            return Math.Min(Math.Min(studentas1.ImtiUgi(), studentas2.ImtiUgi()), studentas3.ImtiUgi());
        }
        static public void MaziausioUgioSpausdinimas(Studentas studentas1, Studentas studentas2, Studentas studentas3)
        {
            double maziausias = MaziausiasUgis(studentas1, studentas2, studentas3);
            if (maziausias == studentas1.ImtiUgi())
                Console.WriteLine("Maziausias Ugis yra: {0}", studentas1.ImtiUgi());
            if (maziausias == studentas2.ImtiUgi())
                Console.WriteLine("Maziausias Ugis yra: {0}", studentas2.ImtiUgi());
            if (maziausias == studentas3.ImtiUgi())
                Console.WriteLine("Maziausias Ugis yra: {0}", studentas3.ImtiUgi());
        }
        static public string KiekKartu(double visasSvoris, Liftas liftas1)
        {
            string kartai;
            {
                if (visasSvoris <= liftas1.ImtiGalia() && liftas1.ImtiTalpa() >= 3)
                    kartai = "1 karta";
                else
                    kartai = "Daugiau nei 1 karta"; // nesugebu sudet
            }
            return kartai;
        }
        static public void SpausdintiKiekKartu(string kartai)
        {
            Console.WriteLine("Liftas pakels studentus i reikiama auksta per: ", kartai); // ????????

        }
    }
}
