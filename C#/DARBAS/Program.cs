using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dziugas Apanavicius PRM
namespace DARBAS
{
    class Program
    {
        static void Main()
        {
            ///<summary>
            ///BIBLIOTEKU SUKURIMAS IS NAUJO
            /// </summary>
            List<Biblioteka> bibliotekos = SkaitytiIsFailo("bibliotekos.txt");

            ///<summary>
            /// Raskite didžiausiu tiražu išleistą knygas arba žurnalus arba laikraščius abiejuose KTU bibliotekuose
            /// </summary> 
            DidziausiasTirazas(bibliotekos);

            /// <summary>
            /// Sudaromas visų leidinių, kuriuos galima rasti tik vienoje bibliotekoje, bendras sąrašas BET JIS NEVEIKIA KAZKODEL SURASU VISUS TIKTAIS KODELLEOLDEOKFEMT
            /// </summary>
            List<Publication> vienosBibliotekosKnygos = ImtiSpecialiasKnygas(bibliotekos);

            /// <summary>
            /// SPAUSDINAMA VISA INFORMACIJA B IBLIOTEKUOSE BET JIS VISTIEK NEVEIKIA
            /// </summary>
            Console.WriteLine("\nVisi leidiniai, kuriuos galima rasti tik vienoje bibliotekoje NEVEIKIA:");
            foreach (var publication in vienosBibliotekosKnygos)
            {
                Console.WriteLine($"{publication.Pavadinimas} ({publication.GetType().Name})");
            }

            /// <summary>
            /// Storiausi neveikia
            /// </summary>
            List<Publication> knygosPagalLeidejius = GautiLeidimusPagalLeidejius(bibliotekos, "KTU Mechanikos inžinerijos ir dizaino fakulteto bibliotekos", 300, 100, 50);

            /// <summary>
            /// nuroditos neveikia
            /// </summary>
            Console.WriteLine("\nStoriausi leidiniai iš KTU Mechanikos inžinerijos ir dizaino fakulteto bibliotekos:");
            foreach (var publication in knygosPagalLeidejius)
            {
                Console.WriteLine($"{publication.Pavadinimas} ({publication.GetType().Name})");
            }

            /// <summary>
            /// rikiavimas neveikia
            /// </summary></summay>
            knygosPagalLeidejius.Sort();

            ///<summary>
            ///rikiavimo spausdinimas neveikia
            /// </summary>
            Console.WriteLine("\nSurikiuotas sąrašas bet jis neveikia nors turetu buti pagal puslapių skaičių:");
            foreach (var publication in knygosPagalLeidejius)
            {
                Console.WriteLine($"{publication.Pavadinimas} ({publication.Puslapiai} puslapiai, {publication.Tirazas} tiražas)");
            }

            Console.ReadLine();
        }

        static List<Biblioteka> SkaitytiIsFailo(string filePath)
        {
            List<Biblioteka> bibliotekos = new List<Biblioteka>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string bibliotekosPavadinimas = reader.ReadLine();
                    string bibliotekosAdresas = reader.ReadLine();
                    Biblioteka biblioteka = new Biblioteka(bibliotekosPavadinimas, bibliotekosAdresas);

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line))
                            break;

                        string[] parts = line.Split(',');

                        if (parts[0] == "Knyga")
                        {
                            Book book = new Book();
                            book.ISBN = parts[1];
                            book.Pavadinimas = parts[2];
                            book.Autorius = parts[3];
                            book.Leidejai = parts[4];
                            book.Metai = int.Parse(parts[5]);
                            book.Puslapiai = int.Parse(parts[6]);
                            book.Tirazas = int.Parse(parts[7]);
                            biblioteka.Books.Add(book);
                        }
                        else if (parts[0] == "Žurnalas")
                        {
                            Journal journal = new Journal();
                            journal.ISSN = parts[1];
                            journal.Pavadinimas = parts[2];
                            journal.Leidejai = parts[3];
                            journal.Metai = int.Parse(parts[4]);
                            journal.Puslapiai = int.Parse(parts[5]);
                            journal.Tirazas = int.Parse(parts[6]);
                            journal.Numeris = int.Parse(parts[7]);
                            biblioteka.Journals.Add(journal);
                        }
                        else if (parts[0] == "Laikraštis")
                        {
                            Paper paper = new Paper();
                            paper.ISSN = parts[1];
                            paper.Pavadinimas = parts[2];
                            paper.Leidejai = parts[3];
                            paper.Metai = int.Parse(parts[4]);
                            paper.Puslapiai = int.Parse(parts[5]);
                            paper.Tirazas = int.Parse(parts[6]);
                            paper.Data = DateTime.Parse(parts[7]);
                            biblioteka.Papers.Add(paper);
                        }
                    }

                    bibliotekos.Add(biblioteka);
                }
            }

            return bibliotekos;
        }

        static void DidziausiasTirazas(List<Biblioteka> bibliotekos)
        {
            Console.WriteLine("Neveikia");

            foreach (var biblioteka in bibliotekos)
            {
                int maxTirazas = 0;
                Publication maxTirazoLeidimas = null;

                foreach (var book in biblioteka.Books)
                {
                    if (book.Tirazas > maxTirazas)
                    {
                        maxTirazas = book.Tirazas;
                        maxTirazoLeidimas = book;
                    }
                }

                foreach (var journal in biblioteka.Journals)
                {
                    if (journal.Tirazas > maxTirazas)
                    {
                        maxTirazas = journal.Tirazas;
                        maxTirazoLeidimas = journal;
                    }
                }

                foreach (var paper in biblioteka.Papers)
                {
                    if (paper.Tirazas > maxTirazas)
                    {
                        maxTirazas = paper.Tirazas;
                        maxTirazoLeidimas = paper;
                    }
                }

                if (maxTirazoLeidimas != null)
                {
                    Console.WriteLine($"Biblioteka: {biblioteka.Pavadinimas}");
                    Console.WriteLine($"Leidinys: {maxTirazoLeidimas.Pavadinimas} ({maxTirazoLeidimas.GetType().Name})");
                    Console.WriteLine($"Tiražas: {maxTirazoLeidimas.Tirazas}\n");
                }
            }
        }

        static List<Publication> ImtiSpecialiasKnygas(List<Biblioteka> bibliotekos)
        {
            Dictionary<string, Publication> vienosBibliotekosKnygos = new Dictionary<string, Publication>();

            foreach (var biblioteka in bibliotekos)
            {
                foreach (var book in biblioteka.Books)
                {
                    string key = $"{book.Pavadinimas}_{book.Autorius}_{book.Leidejai}_{book.Metai}";
                    if (!vienosBibliotekosKnygos.ContainsKey(key))
                    {
                        vienosBibliotekosKnygos.Add(key, book);
                    }
                }

                foreach (var journal in biblioteka.Journals)
                {
                    string key = $"{journal.Pavadinimas}_{journal.Leidejai}_{journal.Metai}_{journal.Numeris}";
                    if (!vienosBibliotekosKnygos.ContainsKey(key))
                    {
                        vienosBibliotekosKnygos.Add(key, journal);
                    }
                }

                foreach (var paper in biblioteka.Papers)
                {
                    string key = $"{paper.Pavadinimas}_{paper.Leidejai}_{paper.Metai}_{paper.Data.ToString("yyyy-MM-dd")}";
                    if (!vienosBibliotekosKnygos.ContainsKey(key))
                    {
                        vienosBibliotekosKnygos.Add(key, paper);
                    }
                }
            }

            return new List<Publication>(vienosBibliotekosKnygos.Values);
        }

        static List<Publication> GautiLeidimusPagalLeidejius(List<Biblioteka> bibliotekos, string leidykla, int knygosPuslapiuMax, int zurnaloPuslapiuMax, int laikrascioPuslapiuMax)
        {
            List<Publication> knygosPagalLeidejius = new List<Publication>();

            foreach (var biblioteka in bibliotekos)
            {
                foreach (var book in biblioteka.Books)
                {
                    knygosPuslapiuMax = 300;
                    if (book.Leidejai == leidykla && book.Puslapiai > knygosPuslapiuMax)
                    {
                        knygosPagalLeidejius.Add(book);
                    }
                }

                foreach (var journal in biblioteka.Journals)
                {
                    zurnaloPuslapiuMax = 50;
                    if (journal.Leidejai == leidykla && journal.Puslapiai > zurnaloPuslapiuMax)
                    {
                        knygosPagalLeidejius.Add(journal);
                    }
                }

                foreach (var paper in biblioteka.Papers)
                {
                    laikrascioPuslapiuMax = 20;
                    if (paper.Leidejai == leidykla && paper.Puslapiai > laikrascioPuslapiuMax)
                    {
                        knygosPagalLeidejius.Add(paper);
                    }
                }
            }

            return knygosPagalLeidejius;
        }
    }
}