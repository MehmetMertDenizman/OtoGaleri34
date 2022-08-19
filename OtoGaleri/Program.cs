using OtoGaleri;
using System.Text.RegularExpressions;

Galeri Galeri = new Galeri();
bool check = true; 
int sayac = 0;
Uygulama();
void Uygulama() {
    while (check)
    {
        Menu();
        string secim = Console.ReadLine().ToUpper();
        switch (secim)
        {
            case "1": case "K": Galeri.ArabaKirala(); break;
            case "2": case "T": Galeri.ArabaTeslimAl();              break;          
            case "3": case "R": Galeri.KiradakiArabalarıListele();   break;
            case "4": case "M": Galeri.GaleridekiArabalarıListele(); break;
            case "5": case "A": Galeri.TumArabalariListele(); break;
            case "6": case "I": Galeri.Kiralamaİptali();             break;
            case "7": case "Y": Galeri.ArabaEkle(Galeri.Arabalar); break;
            case "8": case "S": Galeri.ArabaSil(); break;
            case "9": case "G": Galeri.BilgileriGoster();            break;
            case "10": case "Q": Fake();            break;
            default: sayac++; Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin."); if (sayac == 9) { Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");check = false; };   break;

        }

    }
     }
void Menu()
{
    
    Console.WriteLine("Galeri Otomasyon");
    Console.WriteLine("1 - Araba Kirala(K)");
    Console.WriteLine("2 - Araba Teslim Al(T)");
    Console.WriteLine("3 - Kiradaki Arabaları Listele(R)");
    Console.WriteLine("4 - Galerideki Arabaları Listele(M)");
    Console.WriteLine("5 - Tüm Arabaları Listele(A)");
    Console.WriteLine("6 - Kiralama İptali(I)");
    Console.WriteLine("7 - Araba Ekle(Y)");
    Console.WriteLine("8 - Araba Sil(S)");
    Console.WriteLine("9 - Bilgileri Göster(G)\n");
    Console.Write("Seçiminiz: ");

}
void Fake()
{
    Araba a = new Araba(DURUM.Galeride, "34asa55", "BMW", 333, 0, ARABA_TIPI.SUV);
    Araba a2 = new Araba(DURUM.Kirada, "34fff66", "FORD", 222, 1, ARABA_TIPI.SUV);
    Araba a3 = new Araba(DURUM.Kirada, "34a56", "Mitsubishi", 250, 1, ARABA_TIPI.SUV);
    Araba a4 = new Araba(DURUM.Galeride, "34a456", "Mitsubishi", 333, 0, ARABA_TIPI.SUV);
    Galeri.Arabalar.Add(a);
    Galeri.Arabalar.Add(a2);
    Galeri.Arabalar.Add(a3);
    Galeri.Arabalar.Add(a4);

   
}