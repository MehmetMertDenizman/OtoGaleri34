
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri02
{
    internal class Araba
    {
        public List<int> KiralanmaSureleri = new List<int>();

        public string Plaka;
        public string Marka;
        public float KiralamaBedeli;
        public ARABATIPI ArabaTipi;
        public DURUM Durum = DURUM.Galeride;


        public Araba(string plaka, string marka, float k_bedeli, ARABATIPI a_Tipi)
        {
            this.Plaka = plaka;
            this.Marka = marka;
            this.KiralamaBedeli = k_bedeli;
            this.ArabaTipi = a_Tipi;

        }

        public Araba()
        {

        }

        public int KiralamaSayisi

        {
            get
            {
                return KiralanmaSureleri.Count;
            }

        }


        public int ToplamKiralanmaSuresi
        {
            get
            {
                int toplam = 0;
                foreach (int sure in KiralanmaSureleri)
                {
                    toplam += sure;
                }
                return toplam;

            }
        }



    }



    public enum ARABATIPI
    {
        Empty, SUV, Hatchback, Sedan
    }


    [Flags]
    public enum DURUM
    {
        None = 0,
        Kirada = 1,
        Galeride = 2
    }
}
