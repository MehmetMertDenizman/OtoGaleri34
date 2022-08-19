using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;
using System.Numerics;

namespace OtoGaleri02
{
    internal class Program
    {

        static Galeri G034 = new Galeri();


        static void Main(string[] args)
        {
            Uygulama();
        }

        static void Uygulama()
        {
            SahteVeriGir();
            Menu();

            while (true)
            {
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "K":
                        ArabaKirala();
                        break;
                    case "2":
                    case "T":
                        ArabaTeslimAl();
                        break;
                    case "3":
                    case "R":
                        ArabalarıListele(DURUM.Kirada);//KiradakiArabalarıListele();
                        break;
                    case "4":
                    case "M":
                        ArabalarıListele(DURUM.Galeride);//GaleridekiArabalarıListele();
                        break;
                    case "5":
                    case "A":
                        DURUM durum = DURUM.Galeride | DURUM.Kirada;
                        ArabalarıListele(durum);//TümArabalarıListele();
                        break;
                    case "6":
                    case "I":
                        KiralamaIptali();
                        break;
                    case "7":
                    case "Y":
                        ArabaEkle();
                        break;
                    case "8":
                    case "S":
                        ArabaSil();
                        break;
                    case "9":
                    case "G":
                        BilgileriGoster();
                        break;


                }
            }
        }

        static void SahteVeriGir()
        {
            G034.ArabaEkle("23FGY25", "FORD", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23GY257", "RENAULT", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY25", "TOYOTA", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY26", "TESLA", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY29", "FERRARI", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY21", "AUDI", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY20", "VOLVO", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY28", "FIAT", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY30", "RANGE ROVER", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY31", "LAMBORGHINI", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY32", "MAZDA", 520f, ARABATIPI.SUV);
            G034.ArabaEkle("23FGY33", "SKODA", 520f, ARABATIPI.SUV);
        }

        static void Menu()
        {
            Console.WriteLine("Galeri Otomasyon");
            Console.WriteLine("1- Araba Kirala(K)");
            Console.WriteLine("2- Araba Teslim Al(T)");
            Console.WriteLine("3- Kiradaki Arabaları Listele(R)");
            Console.WriteLine("4- Galerideki Arabaları Listele(M)");
            Console.WriteLine("5- Tüm Arabaları Listele(A)");
            Console.WriteLine("6- Kiralama İptali(I)");
            Console.WriteLine("7- Araba Ekle(Y)");
            Console.WriteLine("8- Araba Sil(S)");
            Console.WriteLine("9- Bilgileri Göster(G)");
        }

        static string SecimAl()
        {
            int hataSayaci = 0;
            Console.WriteLine();
            string karakterler = "123456789KTRMAIYSG";
            do
            {
                Console.Write("Seçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (karakterler.IndexOf(secim) > -1 && secim.Length == 1)   //IndexOf() => Reports the zero-based index of the first occurrence of the specified string in this instance.
                {
                    return secim;
                }

                if (hataSayaci == 9)
                {
                    Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin." + Environment.NewLine);
                    hataSayaci++;

                }



            } while (true);

        }

        static void ArabaKirala()
        {
            Console.WriteLine();
            Console.WriteLine("-Araba Kirala-" + Environment.NewLine);
            bool isValid = false;
            string displayMessage = string.Empty;
            string plaka;
            //(bool, Araba) gecerlilikVeAraba = default;
            Araba aktifAraba = null;
            do
            {

                Console.Write(displayMessage + "Kiralanacak arabanın plakası: ");
                displayMessage = string.Empty;

                plaka = Console.ReadLine().ToUpper();

                if (!G034.PlakaKontrol(plaka))
                {
                    displayMessage = "Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin." + Environment.NewLine;
                    continue;
                }

                //gecerlilikVeAraba = G034.GalerideMi(plaka);
                aktifAraba = G034.GalerideMi2(plaka);

                if (aktifAraba is null) //(!gecerlilikVeAraba.Item1)
                {
                    displayMessage = "Galeriye ait bu plakada bir araba yok." + Environment.NewLine;
                    continue;
                }

                if (aktifAraba.Durum == DURUM.Kirada)
                {
                    displayMessage = "Araba şu anda kirada. Farklı araba seçiniz." + Environment.NewLine;
                    continue;
                }

                isValid = true;

            } while (!isValid);


            int sure;
            do
            {
                Console.Write("Kiralama süresi: ");
                string giris = Console.ReadLine();


                if (!int.TryParse(giris, out sure))
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyin." + Environment.NewLine);
                    isValid = false;
                    continue;
                }

                isValid = true;

            } while (!isValid);


            aktifAraba.Durum = DURUM.Kirada;
            aktifAraba.KiralanmaSureleri.Add(sure);
            Console.WriteLine();
            Console.WriteLine(plaka + " plakalı araba " + sure + " saatliğine kiralandı.");

            //G034.ArabaKiralama(plaka, sure);

        }

        static void ArabaTeslimAl()

        {
            Console.WriteLine();
            Console.WriteLine("-Araba Teslim Al-" + Environment.NewLine);
            Araba aktifAraba = null;
            bool isValid = false;
            string plaka;

            do
            {

                Console.Write("Teslim edilecek arabanın plakası:");
                plaka = Console.ReadLine().ToUpper();

                if (!G034.PlakaKontrol(plaka))
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    continue;
                }


                aktifAraba = G034.GalerideMi2(plaka);

                if (aktifAraba is null)
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    continue;
                }

                if (aktifAraba.Durum == DURUM.Galeride)
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                    continue;
                }

                isValid = true;

            } while (!isValid);

            aktifAraba.Durum = DURUM.Galeride;
            Console.WriteLine();
            Console.WriteLine("Araba galeride beklemeye alındı.");
            //G034.ArabaTeslimAlim(plaka)

        }

        static void ArabalarıListele(DURUM durum)
        {
            string baslik = string.Empty;
            string liste = G034.ArabalarListele(durum);
            switch (durum)
            {

                case (DURUM.Kirada | DURUM.Galeride):
                    baslik = "-Tüm";

                    break;
                case DURUM.Kirada:
                    baslik = "-Kiradaki";

                    break;
                case DURUM.Galeride:
                    baslik = "-Galerideki";

                    break;
            }
            Console.WriteLine();
            Console.WriteLine(baslik + " Arabalar-" + Environment.NewLine);
            Console.WriteLine("Plaka".PadRight(12) + "Marka".PadRight(12) + "K.Bedeli".PadRight(14) + "Araba Tipi".PadRight(16) + "K.Sayısı".PadRight(16) + "Durum".PadRight(8));
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(liste);
        }

        static void KiralamaIptali()
        {
            Console.WriteLine();
            Console.WriteLine("-Kiralama İptali-" + Environment.NewLine);

            bool isValid = false;
            string plaka;
            Araba aktifAraba = null;

            do
            {

                Console.Write("Kiralaması iptal edilecek arabanın plakası:");
                plaka = Console.ReadLine().ToUpper();

                if (!G034.PlakaKontrol(plaka))
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    continue;
                }

                aktifAraba = G034.GalerideMi2(plaka);

                if (aktifAraba == null)
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                }

                if (aktifAraba.Durum == DURUM.Galeride)
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                    continue;
                }

                isValid = true;

            } while (!isValid);

            aktifAraba.Durum = DURUM.Galeride;

            Console.WriteLine();
            Console.WriteLine("İptal gerçekleştirildi.");


            // G034.KiralamaIptal(plaka);

        }
        static void ArabaEkle()
        {
            bool isValid = false;
            string plaka;
            Araba aktifAraba;

            Console.WriteLine();
            Console.WriteLine("-Araba Ekle-" + Environment.NewLine);

            do
            {
                Console.Write("Plaka: ");
                plaka = Console.ReadLine().ToUpper();


                if (!G034.PlakaKontrol(plaka))
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    continue;
                }

                foreach (Araba araba in G034.Arabalar)
                {
                    if (araba.Plaka == plaka)
                    {
                        Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                    }
                }

                //aktifAraba = G034.GalerideMi2(plaka);
                //if (aktifAraba.Durum == DURUM.Galeride)
                //{
                //    Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                //    continue;
                //}

                //if (aktifAraba is null)
                //{}

                isValid = true;

            } while (!isValid);



            string marka;

            do
            {
                Console.Write("Marka: ");
                marka = Console.ReadLine();
                marka = marka.Substring(0, 1).ToUpper() + marka.Substring(1).ToLower();

                if (!G034.HarfMi(marka))
                {
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                    isValid = false;
                    continue;
                }

                isValid = true;

            } while (!isValid);


            float kBedel;
            string kiralamaBedeli;
            do
            {
                Console.Write("Kiralama Bedeli: ");
                kiralamaBedeli = Console.ReadLine();

                if (G034.HarfMi(kiralamaBedeli))
                {
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                    isValid = false;
                    continue;
                }

                isValid = true;

            } while (!isValid);

            kBedel = float.Parse(kiralamaBedeli);

            ARABATIPI aTip;
            string secim;


            Console.WriteLine("Araba Tipleri:       ");
            Console.WriteLine(" - SUV için 1         ");
            Console.WriteLine(" - Hatchback için 2  ");
            Console.WriteLine(" - Sedan için 3      ");

            do
            {
                Console.Write("Araba Tipi: ");
                secim = Console.ReadLine();

                if (secim != "1" && secim != "2" && secim != "3")
                {

                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                    isValid = false;
                    continue;
                }

                isValid = true;

            } while (!isValid);

            aTip = G034.ArabaTipiSecimi(secim);

            G034.ArabaEkle(plaka, marka, kBedel, aTip);

            Console.WriteLine();
            Console.WriteLine("Araba başarılı bir şekilde eklendi.");

        }

        static void ArabaSil()
        {
            string plaka;
            bool isValid = false;
            Araba aktifAraba = null;

            Console.WriteLine();
            Console.WriteLine("-Araba Sil -" + Environment.NewLine);

            do
            {
                Console.Write("Silmek istediğiniz arabanın plakasını giriniz: ");
                plaka = Console.ReadLine().ToUpper();

                if (!G034.PlakaKontrol(plaka))
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                }

                aktifAraba = G034.GalerideMi2(plaka);

                if (aktifAraba is null)
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    continue;
                }

                if (aktifAraba.Durum == DURUM.Kirada)
                {
                    Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
                    continue;
                }


                isValid = true;


            } while (!isValid);

            G034.Arabalar.Remove(aktifAraba);
            //G034.ArabaSil(plaka);
            Console.WriteLine();
            Console.WriteLine("Araba silindi.");
            Console.WriteLine();

        }


        static void BilgileriGoster()   // 2 item daha eklemek gerekiyor. 
        {


            int kiradakiAracSayisi = G034.KiradakiAracNo(0);

            Console.WriteLine();
            Console.WriteLine("-Galeri Bilgileri-");
            Console.WriteLine("Toplam araba sayısı: " + G034.Arabalar.Count());
            Console.WriteLine("Kiradaki araba sayısı: " + kiradakiAracSayisi);
            Console.WriteLine("Bekleyen araba sayısı: " + (G034.Arabalar.Count() - kiradakiAracSayisi));
            Console.WriteLine("Toplam araba kiralama süresi: " + G034.ToplamArabaKiralamaSuresi());
            Console.WriteLine("Toplam araba kiralama adedi: " + G034.ToplamArabaKiralamaSayisi());
            Console.WriteLine("Ciro: " + G034.Ciro);


        }



    }
}

