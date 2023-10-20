using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DARBAS
{
    class Publication : IComparable<Publication>
    {
        public string Pavadinimas { get; set; }
        public string Leidejai { get; set; }
        public int Metai { get; set; }
        public int Puslapiai { get; set; }
        public int Tirazas { get; set; }

        public int CompareTo(Publication other)
        {
            if (this.Puslapiai == other.Puslapiai)
                return this.Tirazas.CompareTo(other.Tirazas);
            else
                return this.Puslapiai.CompareTo(other.Puslapiai);
        }
    }

    class Book : Publication
    {
        public string ISBN { get; set; }
        public string Autorius { get; set; }
    }

    class Journal : Publication
    {
        public string ISSN { get; set; }
        public int Numeris { get; set; }
    }

    class Paper : Publication
    {
        public string ISSN { get; set; }
        public DateTime Data { get; set; }
    }
}
