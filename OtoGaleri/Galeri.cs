using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OtoGaleri
{
    public class Galeri
    {

        

        Regex regex = new Regex("([0-9]{2,2})([a-zA-Z]{1,3})([0-9]{1,4})$");
          public static List<Araba> Arabalar = new List<Araba>();
        public void ArabaEkle(List<Araba> araba)
        {
                 
                Arabalar.Add(new Araba());
            //ciro += arabaKirabedeli * saati
            
        }
        public static List<Araba> GetirListe()
        {
            return Arabalar;
        }

        List<string> strings = new List<string>() { "Plaka", "Marka", "K. Bedeli", "Araba Tipi", "K. Sayısı", "Durum" };
        
        public void ArabaKirala()
        {
            bool cikUlancik = false;
            Console.WriteLine("-Araba Kirala-");
            while (!cikUlancik)
            {


                // saatler verdim regex için, 00 ile başlayan plaka sorunu var.
                Console.Write("Kiralanacak arabanın plakası: ");
                string kiralanacakArabaPlakasi = Console.ReadLine();


                if (regex.IsMatch(kiralanacakArabaPlakasi.ToUpper()) == false)
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                }

                else if (Arabalar.Exists(x => x.Plaka.ToUpper().Equals(kiralanacakArabaPlakasi.ToUpper())))
                {
                    foreach (Araba i in Arabalar)
                    {
                        if (i.Plaka.ToUpper() == kiralanacakArabaPlakasi.ToUpper() && i.Durum == DURUM.Kirada)
                        {
                            Console.WriteLine("Araba şu anda kirada. Farklı araba seçiniz.");
                        }
                    }
                }
                else if (!Arabalar.Exists(x => x.Plaka.ToUpper().Equals(kiralanacakArabaPlakasi.ToUpper())))
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");//TAMAM
                }

                if (regex.IsMatch(kiralanacakArabaPlakasi.ToUpper()) == true && Arabalar.Exists(x => x.Plaka.ToUpper().Equals(kiralanacakArabaPlakasi.ToUpper())) && Arabalar.Exists(x => x.Durum.Equals(DURUM.Galeride)))
                {
                    foreach (Araba i in Arabalar)
                    {
                        if (i.Plaka.ToUpper() == kiralanacakArabaPlakasi.ToUpper() && i.Durum == DURUM.Galeride)
                        {
                            Console.Write("Kiralama süresi: ");
                            Araba.KiralamaSuresi = int.Parse(Console.ReadLine());
                            Araba.KiralamaAdet += 1;
                            Console.WriteLine();
                            Console.WriteLine(kiralanacakArabaPlakasi.ToUpper() + " Plakalı araba " + Araba.KiralamaSuresi + " saatliğine kiralandı.\n");
                            i.Durum = DURUM.Kirada;
                            Araba.Ciro += Araba.KiralamaSuresi * i.KiralamaBedeli;
                            cikUlancik = true;
                            break;
                           
                        }

                    }

                }







            }
        }// TAMAMDIR
        public void TumArabalariListele()
        { 
            Console.WriteLine("-Tüm Arabalar-");
            Console.Write(String.Format("{0,-20}", strings[0]));
            Console.Write(String.Format("{0,-20}", strings[1]));
            Console.Write(String.Format("{0,-20}", strings[2]));
            Console.Write(String.Format("{0,-20}", strings[3]));
            Console.Write(String.Format("{0,-20}", strings[4]));
            Console.Write(String.Format("{0,-20}", strings[5]));
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
            Arabalar.ForEach(x => Console.WriteLine($"{x.Plaka.ToUpper(),-19} {x.Marka.ToUpper(),-19} { x.KiralamaBedeli ,-19} {x.Araba_Tipi.ToString().ToUpper(),-19} {x.KiralamaSayisi,-19} {x.Durum,-19}"));
            Console.WriteLine();
        }// TAMAMDIR
        
        public void ArabaTeslimAl()
        {
            bool cikis = false;
            Console.WriteLine("-Araba Teslim Al-");
            while (!cikis)
            {

                Console.Write("Teslim edilecek arabanın plakası: ");
                string teslimAlinacakAraba = Console.ReadLine();
                if (regex.IsMatch(teslimAlinacakAraba.ToUpper()) == false)
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                }
                if (regex.IsMatch(teslimAlinacakAraba.ToUpper()) == true)
                {
                    if (Arabalar.Exists(x => x.Plaka.ToUpper().Equals(teslimAlinacakAraba.ToUpper())))
                    {
                        foreach (Araba i in Arabalar)
                        {
                            if (i.Plaka.ToUpper() == teslimAlinacakAraba.ToUpper() && i.Durum == DURUM.Galeride)
                            {
                                Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                            }


                        }
                        foreach (Araba i in Arabalar)
                        {


                            if ((i.Plaka.ToUpper() == teslimAlinacakAraba.ToUpper() && i.Durum == DURUM.Kirada))
                            {
                                i.Durum = DURUM.Galeride;
                                Console.WriteLine();
                                Console.WriteLine("Araba galeride beklemeye alındı.\n");
                                cikis = true;
                                break;
                            }
                        }
                    }


                    else if (!Arabalar.Exists(x => x.Plaka.ToUpper().Equals(teslimAlinacakAraba.ToUpper())))
                    {
                        Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    }

                }




            }
        }//TAMAM
        public void ArabaSil()
        {



            bool cikUlanCik = false;
            Console.WriteLine("-Araba Sil-");
            while (!cikUlanCik)
            {

                 
                Console.Write("Silmek istediğiniz arabanın plakasını giriniz: ");
                string silinecekArabaPlakasi = Console.ReadLine();
                Console.WriteLine();
                if (Arabalar.Exists(x => x.Plaka.ToUpper() == silinecekArabaPlakasi.ToUpper() &&  (int)x.Durum == 1))
                {
                    Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
                }
                if (regex.IsMatch(silinecekArabaPlakasi.ToUpper()) == false)
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");//!!!!!!!!
                }
               else if (!Arabalar.Exists(x => x.Plaka.ToUpper().Equals(silinecekArabaPlakasi.ToUpper())))
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                }
                if (Arabalar.Exists(x => x.Plaka.ToUpper() == silinecekArabaPlakasi.ToUpper() && (int)x.Durum == 2))
                {
                    Arabalar.RemoveAll(x => x.Plaka.ToUpper().Equals(silinecekArabaPlakasi.ToUpper()));
                    Console.WriteLine("Araba silindi.\n");
                    cikUlanCik = true;
                }
               


               


                
            }


        }//TAMAM
        public void Kiralamaİptali()
        {

            bool cikUlanCik = false;
            Console.WriteLine("-Kiralama İptali-");
            while (!cikUlanCik)
            {


                Console.Write("Kiralaması iptal edilecek arabanın plakası: ");
                string kiralamaIptalPlakasi = Console.ReadLine();
                 
                if (Arabalar.Exists(x => x.Plaka.ToUpper() == kiralamaIptalPlakasi.ToUpper() && (int)x.Durum == 2))
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride. ");

                    
                }
                if (Arabalar.Exists(x => x.Plaka.ToUpper() == kiralamaIptalPlakasi.ToUpper() && (int)x.Durum == 1))
                {
                    foreach(Araba i in Arabalar)
                        {


                        if ((i.Plaka.ToUpper() == kiralamaIptalPlakasi.ToUpper() && i.Durum == DURUM.Kirada))
                        {
                            i.Durum = DURUM.Galeride;
                            
                            Console.WriteLine("\nİptal gerçekleştirildi.\n");
                            cikUlanCik = true;
                            break;
                        }
                    }
                   
                }
                if (regex.IsMatch(kiralamaIptalPlakasi.ToUpper()) == false)
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin."); 
                }
                else if (!Arabalar.Exists(x => x.Plaka.ToUpper().Equals(kiralamaIptalPlakasi.ToUpper())))
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                }
               







            }

        }
        public void KiradakiArabalarıListele()
        {




            Console.WriteLine("-Kiradaki Arabalar-");
            Console.Write(String.Format("{0,-20}", strings[0]));
            Console.Write(String.Format("{0,-20}", strings[1]));
            Console.Write(String.Format("{0,-20}", strings[2]));
            Console.Write(String.Format("{0,-20}", strings[3]));
            Console.Write(String.Format("{0,-20}", strings[4]));
            Console.Write(String.Format("{0,-20}", strings[5]));
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
            foreach (Araba i in Arabalar) { if (i.Durum == DURUM.Kirada) { Console.WriteLine($"{i.Plaka.ToUpper(),-19} {i.Marka.ToUpper(),-19} {i.KiralamaBedeli,-19} {i.Araba_Tipi.ToString().ToUpper(),-19} {i.KiralamaSayisi,-19} {i.Durum,-19}"); } }
        }//TAMAM
        public void GaleridekiArabalarıListele()
        {
            Console.WriteLine("-Galerideki Arabalar-");
            Console.Write(String.Format("{0,-20}", strings[0]));
            Console.Write(String.Format("{0,-20}", strings[1]));
            Console.Write(String.Format("{0,-20}", strings[2]));
            Console.Write(String.Format("{0,-20}", strings[3]));
            Console.Write(String.Format("{0,-20}", strings[4]));
            Console.Write(String.Format("{0,-20}", strings[5]));
            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
            foreach (Araba i in Arabalar) { if (i.Durum == DURUM.Galeride) { Console.WriteLine($"{i.Plaka.ToUpper(),-19} {i.Marka.ToUpper(),-19} {i.KiralamaBedeli,-19} {i.Araba_Tipi.ToString().ToUpper(),-19} {i.KiralamaSayisi,-19} {i.Durum,-19}"); } }
        }// TAMAMDIR
        public void BilgileriGoster()
        {
            Console.WriteLine("Toplam araba sayısı: " + Arabalar.Count());
             int sayacKira = 0;
            foreach (Araba i in Arabalar) 
            {  if (i.Durum == DURUM.Kirada)
                {
                    sayacKira++; 
                } 
            }
            int sayacGaleri = 0;
            foreach (Araba i in Arabalar)
            {
                if (i.Durum == DURUM.Galeride)
                {
                    sayacGaleri++;
                }
            }
            Console.WriteLine("Kiradaki araba sayısı: " + sayacKira);
            Console.WriteLine("Bekleyen araba sayısı: " + sayacGaleri);
            Console.WriteLine("Toplam araba kiralama süresi: " + Araba.KiralamaSuresi);
            Console.WriteLine("Toplam araba kiralama adedi: " + Araba.KiralamaAdet);
            Console.WriteLine("Ciro: " + Araba.Ciro);
        }
    }
}