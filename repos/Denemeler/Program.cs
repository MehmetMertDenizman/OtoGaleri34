using System.Collections.Generic;
using System.Collections;
using Internal;
using System;

namespace Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code in Main()");


            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            //Console.WriteLine("Boy gir");
            //double boy = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kilot gir");
            //double kilo = Convert.ToDouble(Console.ReadLine());
            //double boymetre = boy / 100;
            //double bki =  kilo / (boymetre * boymetre)  ;

            //if (bki >= 18 && bki <= 25)
            //    Console.WriteLine("Obez değilsin lan");
            //else if (bki < 18)
            //    Console.WriteLine("Kemiksin");
            //else
            //    Console.WriteLine("Obez ibne");

            //Console.WriteLine("Sayı gir:");
            //string sayi = Console.ReadLine();
            //int sayi2 = Int32.Parse(sayi);

            //int result = 0;


            //for (int i=0;i <= sayi2; i++)
            //        result += i;

            //        if (result / sayi2 >= 50) {


            //            Console.WriteLine("50den büyük");
            //        }
            //        else {
            //                Console.WriteLine("50den küçük"); }



            //Console.WriteLine(result);


            //int sayi;
            //int adet = 0;
            //int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 70, 55, 65, 5, 20 };
            //sayi = Convert.ToInt32(Console.ReadLine());    
            //for(int i=0; i<sayilar.Length; i++)

            //{
            //    if (sayi == sayilar[i])
            //    {
            //        adet++;
            //        Console.WriteLine(sayilar[i]);
            //    }
            //    }

            //LİSTE TEK ÇİFT TOPLA ÇIKAR KARIŞIK
            //List<int> liste = new List<int>();
            //int tekresult = 0;
            //int evenresult = 0;
            //int input;
            //int tektoplam = 0;
            //int eventoplam = 0;

            // for(int i = 0; i < 5; i++) { 


            //        Console.WriteLine("New number:");
            //        input = Convert.ToInt32(Console.ReadLine());
            //        liste.Add(input);
            //}
            //foreach (int a in liste) {

            //    if (a % 2 == 0) { 
            //        eventoplam += a;
            //        evenresult+=1;
            //    }
            //    if (a % 2 == 1) {
            //            tektoplam += a;
            //            tekresult += 1;
            //        }





            //}
            //if (tektoplam > eventoplam)
            //    Console.WriteLine("TEKLER BÜYÜK");
            //else
            //    Console.WriteLine("ÇİFTLER BÜYÜK");
            //Console.WriteLine("Tek sayı " + tekresult);
            //Console.WriteLine("Even sayı " + evenresult);
            //Console.WriteLine("Tek sayı TOPLAM:" + tektoplam);
            //Console.WriteLine("Even sayı TOPLAM:" + eventoplam);

            //////////////////////////////////////////////////////

            //int input = Convert.ToInt32(Console.ReadLine());
            //static int karele(int x)
            //{
            //    int kare = x * x;
            //    return kare;

            //}
            //Console.WriteLine(karele(input));
            //if (karele(input) >= 25) { 
            //    Console.WriteLine("25den büyyük");
            //}
            //else { 
            //    Console.WriteLine("25den küçük");}



            //Denemeler.Araba araba1 = new Denemeler.Araba(4, "WOSWOS", "pembiş");

            //Console.WriteLine(araba1.kapiSayisi);
            //Console.WriteLine(araba1.arabaModel);
            //Console.WriteLine(araba1.arabaRengi);

            //Denemeler.Customer customera = new Denemeler.Customer();

            //customera.city = "Ankara0";
            //customera.cms("Mehmet", "ANkararaa");
            //customera.cms


            //ÖĞRENCİ BİLGİ SİSTEMİ
            //bool kontrol = true;


            //Denemeler.Student stud = new Denemeler.Student(5, "Mert", "Denizman", 35, 45, 66, "Gürlek");
            //int s_b = stud.ogrenciOrtalamaBul();
            //Console.WriteLine(stud);



            //secim();
            //while (kontrol) {
            //    string sec = Console.ReadLine();
            //    switch (sec)
            //    {
            //        case "1":
            //            stud.ogrenciBilgileriGoster();
            //            break;
            //         case "2":
            //            int ogrenciortalama = stud.ogrenciOrtalamaBul();
            //            Console.WriteLine(ogrenciortalama);
            //            break;
            //        case "3":
            //            stud.okulGetir();
            //            break;
            //        case "4":
            //            kontrol = false;
            //            break;
            //    }
            //}

            //static void secim()
            //{
            //    Console.WriteLine("1- Öğrenci bilgileri göster");
            //    Console.WriteLine("2- Ortalama göster");
            //    Console.WriteLine("3- okulu göster");
            //    Console.WriteLine("4- Exit");
            //}

            //Denemeler.Kapsul ogrenci = new Denemeler.Kapsul();
            //ogrenci.setName("MERTTTT");
            //string a =ogrenci.getName();
            //Console.WriteLine(a);




            //Denemeler.Kapsul kapsul = new Denemeler.Kapsul();
            //kapsul.kiloGet = 55;

            //Console.WriteLine("Kilon: " + kapsul.kiloGet);

            //Denemeler.KapsulOdev tcgir = new Denemeler.KapsulOdev();
            ////tcgir.tc = 34567123113;
            //Console.WriteLine("Tc gir");
            //Denemeler.KapsulOdev tcgirin = new Denemeler.KapsulOdev();
            //tcgirin.tc =  Console.ReadLine();
            //Denemeler.KapsulOdev.anan();

            //Denemeler.StaticD staticD = new Denemeler.StaticD(55, "mert", "denizman", 5555);
            //staticD.bilgileriGoster();
            //staticD.zamYap(2444);
            //Denemeler.StaticD.zamYap


            //ARRAYLIST

            //ArrayList koleksiyon = new ArrayList();
            //koleksiyon.Add("kaka");
            //koleksiyon.Add("anan");
            //koleksiyon.Add("banan");
            //koleksiyon.Add("xyadada");
            //int b = koleksiyon.Count;
            //int a = koleksiyon.Capacity;
            //koleksiyon.Sort();

            //foreach(var i in koleksiyon) { 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(b + "countu" + "bu da kapasiti" + a );
            //Denemeler.FirstClass prot = new Denemeler.FirstClass();

            //Internal.InternalAccess internalAccess = new Internal.InternalAccess();
            //internalAccess.publicMethod();

            //Denemeler.Hayvan hayvan = new Denemeler.Hayvan();
            ////hayvan.hayvanInfo("Roksy", "Dişi", "Kahverengi", 22);
            //Denemeler.Kedi kedi = new Denemeler.Kedi();
            //kedi.renk = "Siyah";
            //kedi.isim = "Roks";
            //kedi.cinsiyet = "Erkek";
            //kedi.age = 12;
            //kedi.hayvanInfo();
            //kedi.paw = "üç";
            //ArrayList arrayList;

            //Denemeler.Customer customer = new Denemeler.Customer();
            //Denemeler.Manager m1 = new Denemeler.Manager(3169, "Mert", "Denizman", 3);

            //m1.zam(333);
            //            Denemeler.Hayvan hayvan = new Denemeler.Hayvan("Hayvan bu");
            //            Denemeler.Hayvan dog = new Denemeler.Dog("İt");
            //            Denemeler.Hayvan cat = new Denemeler.Cat("Kedi");
            //            dog.speak();
            //            hayvan.speak();
            //            cat.speak();bbb

            //animalSpeak(new Cat("nan"));
            //animalSpeak(new Dog("MAhmyut"));
            //static void animalSpeak(Hayvan anan)
            //{
            //    anan.speak();
            //}

            Console.WriteLine("Şekil app welcome");

            while(true)
            {
                Console.WriteLine("İşlem seç");
                Console.WriteLine("1-Dik");
                Console.WriteLine("2-Üçgen");
                Console.WriteLine("3-Kare");
                Console.WriteLine("4-Quit");
                int secim = Convert.ToInt32(Console.ReadLine());
                if(secim == 4)
                {
                    break;
                } 
                else if (secim == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1-Dikdört alanı");
                        Console.WriteLine("2-Dikdört info");
                        Console.WriteLine("3-Çıkış");
                        Console.WriteLine("4-Üst menüye");
                    }
                }
                else if (secim == 2)
                {
                    while (true)
                    {

                        Console.WriteLine("1-Üçgen alanı");
                        Console.WriteLine("2-Üç info");
                        Console.WriteLine("3-Çıkış");
                        Console.WriteLine("4-Üst menüye");
                    }
                }
                else if (secim == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("1-Kare alanı");
                        Console.WriteLine("2-Kare info");
                        Console.WriteLine("3-Çıkış");
                        Console.WriteLine("4-Üst menüye");
                        if (secim == 1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }


        }
    }
}