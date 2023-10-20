using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DARBAS
{
    internal class Biblioteka
    {
        public string Pavadinimas { get; set; }
        public string Adresas { get; set; }
        public List<Book> Books { get; set; }
        public List<Journal> Journals { get; set; }
        public List<Paper> Papers { get; set; }

        public Biblioteka(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Books = new List<Book>();
            Journals = new List<Journal>();
            Papers = new List<Paper>();
        }
    }
}
