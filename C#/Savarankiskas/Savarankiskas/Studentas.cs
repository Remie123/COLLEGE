using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas
{
    internal class Studentas
    {
        private int amzius;
        private double ugis;
        private double svoris;

        public Studentas(int amziausreiksme, double ugioreiksme, double svorioreiksme)
        {
            this.amzius = amziausreiksme;
            ugis = ugioreiksme;
            svoris = svorioreiksme;
        }
        public double ImtiUgi() { return ugis; }
        public int ImtiAmziu() { return amzius; }
        public double ImtiSvori() { return svoris; }
    }
}
