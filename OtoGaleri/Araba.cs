using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OtoGaleri.Galeri;

namespace OtoGaleri
{
    public class Araba
    {
        public DURUM Durum;
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }
        public int KiralamaSayisi { get; set; }
        public ARABA_TIPI Araba_Tipi ;
        private static int KiralamaSure;
        public static int KiralamaSuresi {
            get 
            {
                return KiralamaSure;
            } 
            set 
            {
                 KiralamaSure = value;
            } 
        }
        public Araba(DURUM durum, string plaka, string marka, float kiralamaBedeli, int kiralamaSayisi, ARABA_TIPI araba_Tipi)
        {
            Durum = durum;
            Plaka = plaka;
            Marka = marka;
            KiralamaBedeli = kiralamaBedeli;
            KiralamaSayisi = kiralamaSayisi;
            Araba_Tipi = araba_Tipi;
        }

        public Araba()
        {
            Console.Write("Plaka: ");
            this.Plaka = Console.ReadLine();
            Console.Write("Marka: ");
            this.Marka = Console.ReadLine();
            Console.Write("Kiralama Bedeli: ");
            this.KiralamaBedeli = float.Parse(Console.ReadLine());
            Console.Write("Araba Tipi: \nSuv 1\nHatchback 2\nSedan 3");
            this.Araba_Tipi = (ARABA_TIPI)int.Parse(Console.ReadLine()) ;
            this.Durum = DURUM.Galeride;
        }
    }
    public enum ARABA_TIPI
    {
        Empty, SUV, Hatchback, Sedan
    }
    public enum DURUM
    {
        Empty, Kirada, Galeride
    }

}
