using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas
{
    internal class Liftas
    {
        private int galia,
                    talpa;

        // set
        //get neveikia set ir get?!?

        public Liftas(int galiosreiksme, int talposreiksme)
        {
            this.galia = galiosreiksme;
            this.talpa = talposreiksme;
        }
        public int ImtiGalia() { return galia; }

        public int ImtiTalpa() { return talpa; }

        ///<summary>
        /// NEVEIKIA!??!?!?!?!?!?
        ///
        ///        {
        ///    private int ImtiGalia;
        ///    private int ImtiTalpa;
        ///    public int ImtiGalia
        ///    {
        ///        get { return ImtiGalia; }
        ///        set
        ///        {
        ///            if (value >= 0)
        ///            {
        ///                ImtiGalia = value;
        ///            }
        ///        }
        ///    }

        ///    public int ImtiTalpa
        ///    {
        /// get { return ImtiTalpa; }
        /// set
        ///        {
        ///            if (value >= 0 && value <= 10)
        ///            {
        /// ImtiTalpa = value;
        ///            }
        ///        }
        ///    }
        /// </ summary >
        ///}
        ///}
    }
}