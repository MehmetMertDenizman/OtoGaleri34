using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtotGaleri_G034
{
    //galeriye ait veri yönetimi kodlarını içerir.
    internal class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamArabaSayisi
        {
            get
            {
                return Arabalar.Count;
            }
        }
        public int KiradakiArabaSayisi
        {
            get
            {
                int adet = 0;
                foreach (Araba item in Arabalar)
                {
                    if (item.Durum == DURUM.Kirada)
                    {
                        adet++;
                    }
                }
                return adet;
            }
        }
        public int GaleridekiArabaSayısi { get; }
        public int ToplamArabaKiralamaSuresi { get; }
        public int ToplamArabaKiralamaAdedi { get; }
        public float Ciro { get; }

        public void ArabaEkle(string plaka, string marka, float kbedel, ARABA_TIPI aTip)
        {
            Araba a = new Araba(plaka, marka, kbedel, aTip);
            this.Arabalar.Add(a);
            // this.Arabalar.Add(new Araba(plaka, marka, kbedel, aTip));
        }
        public void ArabaKiralama(string plaka, int sure)
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }
            if (a != null)
            {
                a.Durum = DURUM.Kirada;
                //a.KiralamaSayisi++;
                //a.ToplamKiralanmaSuresi += sure;
                a.KiralanmaSureleri.Add(sure);
            }
        }
        public void ArabaTeslimAlim(string plaka)
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka==plaka)
                {
                    a = item;
                }
            }
            if (a!=null)
            {
                a.Durum = DURUM.Galeride;
            }
        }
    }
}