using System;
using System.Collections.Generic;
using siliconDeneme;


List<Ogrenci> ogrenci_listesi = new List<Ogrenci>();
int hataCounter = 0;
bool isProgramRunning = true;


SahteVeriGir();
Uygulama();

void Uygulama()
{
    Menu();
    while (isProgramRunning)
    {
        string giris = SecimAl();
        Console.WriteLine();
        switch (giris)
        {
            case "1":
            case "E":
                OgrenciEkle(ogrenci_listesi);
                break;
            case "2":
            case "L":
                OgrenciListele(ogrenci_listesi);
                break;
            case "3":
            case "S":
                OgrenciSil(ogrenci_listesi);
                break;
            case "4":
            case "X":    //buradan neden çıkış yapmıyor ? 
                isProgramRunning = false;
                break;
            default:
                break;
        }

    }

    Console.WriteLine("Çıkış yapıldı.");
}
static void Menu()
{
    Console.WriteLine("Öğrenci Yönetim Uygulaması  ");
    Console.WriteLine("1 - Öğrenci Ekle(E)         ");
    Console.WriteLine("2 - Öğrenci Listele(L)      ");
    Console.WriteLine("3 - Öğrenci Sil(S)          ");
    Console.WriteLine("4 - Çıkış(X)                ");
    Console.WriteLine();
}
  string SecimAl()

{
    Console.WriteLine();
    Console.Write("Seçiminiz: ");
    string secim = Console.ReadLine().ToUpper();
    int secimNumericVal = 0;
    if (int.TryParse(secim, out int result))
    {
        secimNumericVal = result;
    }
    if ((secim == "E" || secim == "L" || secim == "S" || secim == "X") || (secimNumericVal == 1 || secimNumericVal == 2 || secimNumericVal == 3 || secimNumericVal == 4))
    {

    }
    else if (hataCounter >= 10)
    {
        Console.WriteLine("Üzgünüm sizi anlayamadım. Program sonlandırılıyor.");
        hataCounter = 0;
        isProgramRunning = false;
    }
    else
    {
        Console.WriteLine("Hatalı giriş yapıldı.");
        hataCounter++;
    }

    return secim;
    
    //int sayac = 1;
    //string secim;

    //do
    //{
    //    Console.WriteLine();
    //    Console.Write("Seçiminiz: ");
    //    secim = Console.ReadLine().ToUpper();

    //    if (secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "E" || secim == "L" || secim == "S" || secim == "X")
    //    {
    //        return secim;
    //    }

    //    else if (sayac <= 10 && secim != "1" || secim != "2" || secim != "3" || secim != "4" || secim != "E" || secim != "L" || secim != "S" || secim != "X")
    //    {

    //        if (sayac == 10)
    //        {
    //            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
    //            return null;
    //        }

    //        else if (sayac < 10)
    //        {
    //            Console.WriteLine("Hatalı giriş yapıldı.");
    //            sayac++;
    //            return null;
    //        }
    //    }

    //} while (sayac < 11);



}
  void SahteVeriGir()
{
    Ogrenci ogrenci1 = new Ogrenci();  ///class özelliklerine sahip bir instance yaratıyoruz.
    ogrenci1.Ad = "Naz";
    ogrenci1.Soyad = "Şimşek";
    ogrenci1.Sube = "A";
    ogrenci1.No = 250;
    ogrenci_listesi.Add(ogrenci1);

    Ogrenci ogrenci2 = new Ogrenci();  ///class özelliklerine sahip bir instance yaratıyoruz.
    ogrenci2.Ad = "Naz";
    ogrenci2.Soyad = "Şimşek";
    ogrenci2.Sube = "A";
    ogrenci2.No = 350;
    ogrenci_listesi.Add(ogrenci2);

    Ogrenci ogrenci3 = new Ogrenci();  ///class özelliklerine sahip bir instance yaratıyoruz.
    ogrenci3.Ad = "Naz";
    ogrenci3.Soyad = "Şimşek";
    ogrenci3.Sube = "A";
    ogrenci3.No = 450;
    ogrenci_listesi.Add(ogrenci3);

    Ogrenci ogrenci4 = new Ogrenci();  ///class özelliklerine sahip bir instance yaratıyoruz.
    ogrenci4.Ad = "Naz";
    ogrenci4.Soyad = "Şimşek";
    ogrenci4.Sube = "A";
    ogrenci4.No = 550;
    ogrenci_listesi.Add(ogrenci4);
}
static void OgrenciListele(List<Ogrenci> ogr_list)
{

    if (ogr_list.Count == 0)
    {
        Console.WriteLine("Gösterilecek öğrenci yok.");
    }

    else
    {
        Console.WriteLine("2 - Öğrenci Listele---------- ");
        Console.WriteLine();
        Console.WriteLine("Şube    No     Ad Soyad ");
        Console.WriteLine("----------------------------------");

        foreach (Ogrenci x in ogr_list)
        {
            Console.WriteLine(x.Sube.PadRight(8) + x.No.ToString().PadRight(7) + x.Ad + " " + x.Soyad);
        }
    }

}
  void OgrenciEkle(List<Ogrenci> ogr_list)
{
    Ogrenci o = new Ogrenci();
    int index = ogr_list.Count + 1;
    bool isCollidingNumber = false;

    do
    {

        Console.WriteLine("1 - Öğrenci Ekle ----------                                   ");
        Console.WriteLine(index + ". Öğrencinin                                                   ");
        Console.Write("No: ");
        o.No = int.Parse(Console.ReadLine());

        for (int i = 0; i < ogrenci_listesi.Count; i++)
        {
            if (ogrenci_listesi[i].No == o.No)
            {
                isCollidingNumber = true;
                break;
            }
        }

    } while (isCollidingNumber);


    Console.Write("Adı:  ");
    o.Ad = Console.ReadLine();
    o.Ad = o.Ad[0].ToString().ToUpper() + o.Ad.Substring(1).ToLower();

    Console.Write("Soyadı:");
    o.Soyad = Console.ReadLine();
    o.Soyad = o.Soyad[0].ToString().ToUpper() + o.Soyad.Substring(1).ToLower();  //burada neden tostring yapıyoruz ? 

    Console.Write("Şubesi:");
    o.Sube = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E / H)");
    string secim = Console.ReadLine();


    if (secim.ToUpper() == "E")
    {
        ogrenci_listesi.Add(o);
        Console.WriteLine("Öğrenci eklendi.");
    }

    else
    {
        Console.WriteLine("Öğrenci eklenmedi. ");
    }
}
  void OgrenciSil(List<Ogrenci> ogr_list)
{
    Console.WriteLine("3 - Öğrenci Sil  ----------     ");

    if (ogr_list.Count == 0)  // Eğer listede hiç öğrenci yoksa “Silmek istediğiniz öğrencinin” satırını yazdırmadan, “Listede silinecek öğrenci yok.” mesajını versin. => OK
    {
        Console.WriteLine("Listede silinecek öğrenci yok.");
    }

    else
    {
        Console.WriteLine("Silmek istediğiniz öğrencinin ");
        Console.Write("No: ");
        int no = int.Parse(Console.ReadLine());
        Ogrenci o1 = null;
        foreach (Ogrenci s in ogrenci_listesi)
        {
            if (s.No == no)
            {
                o1 = s;
                break;
            }
        }
        if (o1 != null)
        {
            Console.WriteLine("Adı: " + o1.Ad);
            Console.WriteLine("Soyadı:" + o1.Soyad);
            Console.WriteLine("Şubesi:" + o1.Sube);
            Console.WriteLine();
            Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E / H) ");
            string secim = Console.ReadLine();

            if (secim.ToUpper() == "E")
            {
                ogrenci_listesi.Remove(o1);
                Console.WriteLine("Öğrenci silindi. ");
            }
            else
            {
                Console.WriteLine("Öğrenci silinmedi.");
            }
        }
        else
        {
            Console.WriteLine("Böyle bir öğrenci bulunamadı. ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
