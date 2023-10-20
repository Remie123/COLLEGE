using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas
{
    internal class Calculation
    {
        private static int BrangiausiaKnyga(List<Knygos> knyga)
        {
            int brangiknyga = knyga[0].Kaina;
            foreach (Knygos knygos in knyga)
            {
                if (knygos.Kaina.CompareTo(brangiknyga) > 0)
                {
                    brangiknyga = knygos.Kaina;
                }
            }
            return brangiknyga;
        }
        public static void SudetViskaISarasa(List<Knygos> knyga, List<Knygos> newList)
        {
            int brangyknygoskaina = BrangiausiaKnyga(knyga);
            foreach (Knygos knygos in knyga)
            {
                if (brangyknygoskaina == knygos.Kaina)
                    newList.Add(knygos);
            }
        }
        public static void IeskotiAutoriaus(List<Knygos> knyga, List<string> autorius)
        {
            foreach (Knygos knygos in knyga)
            {
                if (!autorius.Contains(knygos.Autorius))
                    autorius.Add(knygos.Autorius);
            }
        }
      
    }
}
