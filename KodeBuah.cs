using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_1302210014
{
    internal class KodeBuah
    {
        public enum Buah
        {
            Apel,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        }

        public static string getKodeBuah(Buah namaBuah)
        {
            string[] arrayKode = new string[] { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return arrayKode[(int)namaBuah];
        }
    }
}
