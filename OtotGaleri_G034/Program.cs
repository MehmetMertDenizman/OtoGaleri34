using System;

namespace OtotGaleri_G034
{
    internal class Program
    {
        //kullanıcı ile etkileşim içerir.
        static Galeri G034Galeri = new Galeri();
        static void Main(string[] args)
        {
            Uygulama();
            //Araba a = new Araba();
            //a.Plaka = "34mKl78545";
        }
        static void Uygulama()
        {
            SahteVeriGir();
            Menu();
            while (true)
            {
                //SecimAl();
                //switch - case
                ArabaEkle();
                ArabaKirala();
                ArabaTeslimAl();
                //ArabaListele();
                //ArabaKiralamaIptali();
                //ArabaSil();
                //BilgileriGetir();
                ARABA_TIPI a = (ARABA_TIPI)2;

            }
        }
         
        static void Menu()
        {
            Console.WriteLine("Galeri Otomasyon                      ");
            Console.WriteLine("1 - Araba Kirala(K)                   ");
            Console.WriteLine("2 - Araba Teslim Al(T)                ");
            Console.WriteLine("3 - Kiradaki Arabaları Listele(R)     ");
            Console.WriteLine("4 - Galerideki Arabaları Listele(M)   ");
            Console.WriteLine("5 - Tüm Arabaları Listele(A)          ");
            Console.WriteLine("6 - Kiralama İptali(I)                ");
            Console.WriteLine("7 - Araba Ekle(Y)                     ");
            Console.WriteLine("8 - Araba Sil(S)                      ");
            Console.WriteLine("9 - Bilgileri Göster(G)               ");
        }
        static void SahteVeriGir()
        {
            G034Galeri.ArabaEkle("23FGY256", "FORD", 520f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 120f, ARABA_TIPI.Hatchback);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 320f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 720f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 420f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 620f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 820f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("23FGY256", "FORD", 920f, ARABA_TIPI.SUV);
        }
        static void ArabaEkle()
        {
            Console.WriteLine("-Araba Ekle ");
            Console.Write("Plaka: ");
            string plaka = "";
            Console.Write("Marka:  ");
            string marka = "";
            Console.Write("Kiralama Bedeli:  ");
            float k_bedeli = 340f;

            Console.WriteLine("Araba Tipleri:       ");
            Console.WriteLine(" - SUV için 1         ");
            Console.WriteLine(" - Hatchback için 2  ");
            Console.WriteLine(" - Sedan için 3      ");
            ARABA_TIPI aTipi;
            Console.Write("Araba Tipi: ");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                aTipi = ARABA_TIPI.SUV;
            }
            G034Galeri.ArabaEkle(plaka, marka, k_bedeli,    ARABA_TIPI.SUV );
        }
        static void ArabaKirala()
        {
            Console.Write("Kiralanacak aracın plakası: ");
            string plaka = Console.ReadLine();
            Console.Write("Süre: ");
            int sure = int.Parse(Console.ReadLine());
            G034Galeri.ArabaKiralama(plaka, sure);
        }
        static void ArabaTeslimAl()
        {
            Console.WriteLine("-Araba Teslim Al-");
            Console.Write("Teslim edilecek arabanın plakası:");
            string plaka = Console.ReadLine();
            G034Galeri.ArabaTeslimAlim(plaka);
        }

    }
}
