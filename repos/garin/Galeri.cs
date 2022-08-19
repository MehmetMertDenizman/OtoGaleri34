using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OtoGaleri02
{
    internal class Galeri
    {


        public List<Araba> Arabalar = new List<Araba>();


        public void ArabaEkle(string plaka, string marka, float kBedel, ARABATIPI aTip)
        {
            Araba a = new Araba(plaka, marka, kBedel, aTip);
            this.Arabalar.Add(a);

        }

        //public void ArabaKiralama(string plaka, int sure)
        //{
        //    Araba a = null;
        //    foreach (Araba item in Arabalar)
        //    {
        //        if (item.Plaka == plaka)
        //        {
        //            a = item;
        //        }
        //    }

        //    if (a != null)
        //    {
        //        a.Durum = DURUM.Kirada;
        //        a.KiralanmaSureleri.Add(sure);
        //    }


        //}

        //public void ArabaTeslimAlim(string plaka)
        //{
        //    Araba a = null;
        //    foreach (Araba item in Arabalar)
        //    {
        //        if (item.Plaka == plaka)
        //        {
        //            a = item;
        //        }
        //    }

        //    if (a != null)
        //    {
        //        a.Durum = DURUM.Galeride;
        //    }
        //}

        //public string PlakaKontrol(string text)
        //{
        //    do
        //    {
        //        Console.Write(text);
        //        string plaka = Console.ReadLine().ToUpper();

        //        int ilkİkiKarakter;
        //        int sonDortKarakter;
        //        int ortadakiKarakter;
        //        bool sayiMi = int.TryParse(plaka.Substring(0, 2), out ilkİkiKarakter); //baştaki iki karakter sayı DEĞİLSE hata versin diye.
        //        bool sayiMi2 = int.TryParse(plaka.Substring(4, 4), out sonDortKarakter); //sondaki iki karakter sayı DEĞİLSE hata versin diye.
        //        bool sayiMi3 = int.TryParse(plaka.Substring(2, 2), out ortadakiKarakter);   // ortadaki iki karakter sayıysa hata versin diye.

        //        if (plaka.Length != 8 || !sayiMi || !sayiMi2 || sayiMi3)
        //        {
        //            Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
        //        }
        //        else
        //        {
        //            return plaka;
        //        }


        //    } while (true);

        //}
        public bool PlakaKontrol(string text) //3 4 G H T 3 4 
        {
            if (text.Length != 7) return false;

            char[] plaka = text.ToCharArray();

            for (int i = 0; i < plaka.Length; i++)
            {

                if ((i == 0 || i == 1 || i == 5 || i == 6) && !Char.IsDigit(plaka[i]))
                {

                    return false;
                }
                else if ((i == 4 && !Char.IsLetterOrDigit(plaka[i])))
                {

                    return false;
                }
                else if ((i == 2 || i == 3) && !Char.IsLetter(plaka[i]))
                {

                    return false;
                }
            }
            return true;
        }



        public (bool, Araba) GalerideMi(string plaka)
        {
            foreach (Araba araba in Arabalar)
            {
                if (araba.Plaka == plaka)
                {

                    return (true, araba);

                }

            }
            return (false, null);

        }

        public Araba GalerideMi2(string plaka)
        {
            foreach (Araba araba in Arabalar)
            {
                if (araba.Plaka == plaka)
                {

                    return araba;

                }

            }
            return null;

        }

        public int KiradakiAracNo(int KiralananAraclarNo)
        {

            foreach (Araba araba in Arabalar)
            {
                if (araba.Durum == DURUM.Kirada)
                {
                    KiralananAraclarNo++;
                }
            }

            return KiralananAraclarNo;

        }

        /*public string DurumKontrol(string plaka)
        {
           
                foreach (Araba araba in Arabalar)
                {

                Araba a = Empty;
                    if (araba.Plaka != plaka)
                    {
                    
                    }

                    else
                    {

                        return plaka;

                    }
                }

        }*/

        public bool HarfMi(string text)
        {

            char[] marka = text.ToCharArray();

            for (int i = 0; i < marka.Length; i++)
            {

                if (Char.IsLetter(marka[i]))
                {

                    return true;
                }

            }

            return false;



            //if (int.TryParse(text, out int result))
            //{

            //return false;

            //}

            //else
            //{
            //return true;
            //}

            //bool isIntString = marka.All(char.IsDigit);

            //if (isIntString)
            //{
            //    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");

            //}

            //else
            //{
            //    return marka;
            //}
        }

        public ARABATIPI ArabaTipiSecimi(string secim)
        {
            ARABATIPI aTip;

            switch (secim)
            {
                case "1":
                    return aTip = ARABATIPI.SUV;

                case "2":
                    return aTip = ARABATIPI.Hatchback;

                case "3":
                    return aTip = ARABATIPI.Sedan;

                default:
                    return aTip = ARABATIPI.Empty;
            }

        }

        public int BedelKontrol(string text)
        {
            do
            {
                Console.Write(text);
                string bedel = Console.ReadLine();
                int kbedel;

                if (int.TryParse(bedel, out kbedel))
                {
                    return kbedel;
                }

                else
                {
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                }
            } while (true);

        }

        //public void ArabaSil(string plaka)
        //{
        //    Araba a = null;
        //    foreach (Araba araba in Arabalar)
        //    {
        //        if (araba.Plaka == plaka)
        //        {
        //            a = araba;
        //        }
        //    }

        //    if (a != null)
        //    {
        //        if (a.Durum == DURUM.Kirada)
        //        {
        //            Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
        //        }

        //        else if (a.Durum != DURUM.Kirada)
        //        {
        //            Arabalar.Remove(a);
        //        }
        //    }



        //}

        public void KiralamaIptal(string plaka)  // =>>>> buraya süre bilgisi de eklemek gerekmez mi ? Ama süre bilgisini nereden bulacağız ? 
        {
            Araba a = null;
            foreach (Araba araba in Arabalar)
            {
                if (araba.Plaka == plaka)
                {
                    a = araba;
                }
            }

            if (a != null)
            {
                if (a.Durum == DURUM.Kirada)
                {
                    a.Durum = DURUM.Galeride;
                }
            }

            //public void KiralanmisArabalar()
            //{
            //    foreach (Araba item in Arabalar)
            //    {
            //        if (item.Durum == DURUM.Kirada)
            //        {
            //            Console.WriteLine(item.Plaka + item.Marka.PadRight(12) + item.KiralamaBedeli.ToString().PadRight(14) + item.ArabaTipi.ToString().PadRight(16) + item.KiralamaSayisi.ToString().PadRight(16) + item.Durum.ToString().PadRight(8));
            //        }
            //    }
            //}

            //public string KiralanmisArabalar()
            //{
            //    string arabaListesi = string.Empty;
            //    foreach (Araba item in Arabalar)
            //    {
            //        if (item.Durum == DURUM.Kirada)
            //        {
            //            arabaListesi += (item.Plaka + item.Marka.PadRight(12) + item.KiralamaBedeli.ToString().PadRight(14) + item.ArabaTipi.ToString().PadRight(16) + item.KiralamaSayisi.ToString().PadRight(16) + item.Durum.ToString().PadRight(8) + Environment.NewLine);
            //        }
            //    }
            //    return arabaListesi;
            //}

            //public void GaleridekiArabalar()
            //{
            //    foreach (Araba item in Arabalar)
            //    {
            //        if (item.Durum == DURUM.Galeride)
            //        {
            //            Console.WriteLine(item.Plaka + item.Marka.PadRight(12) + item.KiralamaBedeli.ToString().PadRight(14) + item.ArabaTipi.ToString().PadRight(16) + item.KiralamaSayisi.ToString().PadRight(16) + item.Durum.ToString().PadRight(8));
            //        }
            //    }
            //}
        }

        public string ArabalarListele(DURUM durum)

        {
            string arabaListesi = string.Empty;
            foreach (Araba araba in Arabalar)
            {
                if ((araba.Durum & durum) != 0)
                {
                    arabaListesi += (araba.Plaka.PadRight(12) + araba.Marka.PadRight(12) + araba.KiralamaBedeli.ToString().PadRight(14) + araba.ArabaTipi.ToString().PadRight(16) + araba.KiralamaSayisi.ToString().PadRight(16) + araba.Durum.ToString().PadRight(8) + Environment.NewLine);
                }

            }
            return arabaListesi;
        }


        public int ToplamArabaKiralamaSayisi()
        {
            int toplam = 0;
            foreach (Araba araba in Arabalar)
            {
                toplam += araba.KiralamaSayisi;

            }
            return toplam;
        }

        public int ToplamArabaKiralamaSuresi()
        {
            int toplamSure = 0;
            foreach (Araba araba in Arabalar)
            {
                toplamSure += araba.ToplamKiralanmaSuresi;
            }
            return toplamSure;
        }

        public float Ciro   // "return" doğru veriyi mi geri döndürüyor ? YANİ => Hesaplanan meblağ mı yoksa 0 mı döndürüyor ? Kontrol et! 
        {
            get
            {
                float ciro = 0;
                foreach (Araba araba in Arabalar)
                {

                    if (araba.Durum == DURUM.Kirada)
                    {
                        ciro += araba.KiralamaBedeli;
                    }
                }

                return ciro;

            }

        }


    }
}