using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static OtoGaleri.Galeri;

namespace OtoGaleri
{
    public class Araba
    {
        public DURUM Durum;
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli;


        public int KiralamaSayisi { get; set; }
        public ARABA_TIPI Araba_Tipi;
        public static int KiralamaSure;
        private static int KiralamaAdedi;

        public static float Ciro;


        public static int KiralamaAdet { get { return KiralamaAdedi; } set { KiralamaAdedi += 1; } }
        public static int KiralamaSuresi
        {
            get
            {
                return KiralamaSure;
            }
            set
            {
                KiralamaSure += value;
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


        List<Araba> listGaleri = Galeri.Arabalar;


        Regex regex = new Regex("([0-9]{2,2})([a-zA-Z]{1,3})([0-9]{1,4})$");
        Regex regexMarka = new Regex("([a-zA-z]{3,18})$");
        Regex regexBedel = new Regex("([0-9]{1,3})$");
        public Araba()
        {

            bool check = false;
            Console.WriteLine("-Araba Ekle-");
            while (!check)
            {   c:
                Console.Write("Plaka: ");
                this.Plaka = Console.ReadLine().ToUpper();

                if (regex.IsMatch(this.Plaka.ToUpper()) == true)
                {
                    foreach (Araba i in listGaleri)
                    {
                        if (this.Plaka.ToUpper() == i.Plaka.ToUpper())
                        {
                            Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                            goto c;
                        }
                        
                    }
                    if (regex.IsMatch(Plaka.ToUpper())== true)
                    {
                    b:
                        Console.Write("Marka: ");
                        this.Marka = Console.ReadLine().ToUpper();
                         
                    
                    if (regexMarka.IsMatch(this.Marka.ToUpper()) == false)
                        {
                            Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                            goto b;
                        }
                        else if (regexMarka.IsMatch(this.Marka.ToUpper()) == true)
                        {
                        a:
                            Console.Write("Kiralama Bedeli: ");
                            string kiralama = Console.ReadLine();
                            if (regexBedel.IsMatch(kiralama) == false)
                            {
                                Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                                goto a;
                            }
                            if (regexBedel.IsMatch(kiralama) == true)
                            {
                                KiralamaBedeli = float.Parse(kiralama);


                                if (regexBedel.IsMatch(KiralamaBedeli.ToString()))
                                {d:
                                    Console.WriteLine("Araba Tipleri: \nSuv 1\nHatchback 2\nSedan 3");
                                    Console.Write("Araba Tipi: ");
                                    this.Araba_Tipi = (ARABA_TIPI)int.Parse(Console.ReadLine());
                                    if ((int)Araba_Tipi == 1 || (int)Araba_Tipi == 2 || (int)Araba_Tipi == 3)
                                    {
                                        this.Durum = DURUM.Galeride;
                                        Console.WriteLine("Araba başarılı bir şekilde eklendi.");
                                        check = true;
                                        break;
                                    }
                                    if ((int)Araba_Tipi != 1 || (int)Araba_Tipi != 2 || (int)Araba_Tipi != 3)
                                    {
                                        Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                                        goto d;
                                        //Console.WriteLine("Araba Tipleri: \nSuv 1\nHatchback 2\nSedan 3");
                                        //Console.Write("Araba Tipi: ");
                                        //this.Araba_Tipi = (ARABA_TIPI)int.Parse(Console.ReadLine());
                                    }
                                    
                                    if (!regex.IsMatch(Plaka.ToUpper())) { Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin."); }

                                }
                            }
                        }
                    }





                }

                if (!regex.IsMatch(this.Plaka.ToUpper()))
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");


                }







            }

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
