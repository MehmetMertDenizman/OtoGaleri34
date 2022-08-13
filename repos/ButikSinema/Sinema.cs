using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikSinema
{
    public class Sinema
    {
        public string filmAdi;
        public int kapasite;
        public int tam;
        public int yarim;

        public Sinema(  )
        {
             
            
        
               
            Console.Write("Film adı: "  );
            this.filmAdi = Console.ReadLine();
            Console.Write("Kapasite: "  );
            this.kapasite = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı: "    );
            this.tam   = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı: " );
            this.yarim = int.Parse(Console.ReadLine());
        }
        public void Secim()
        {
            Console.Write("Seçiminiz: ");
            Console.ReadLine();
        }
        public void Menu() 
        {
            Console.WriteLine("-----Butik Sinema Salonu-----");
            Console.WriteLine("Film adı: " + filmAdi);
            
            Console.WriteLine("Kapasite: " + kapasite);
            Console.WriteLine("Tam Bilet Fiyatı: " + tam);
            Console.WriteLine("Yarım Bilet Fiyatı: " + yarim);

            Console.WriteLine("1-Bilet Sat (S)");
            Console.WriteLine("2-Bilet İade (R)");
            Console.WriteLine("3-Durum Bilgisi (D)");
            Console.WriteLine("4-Çıkış (X)");
            Secim();
        }
        public void BosKoltuk()
        {
            Console.WriteLine(kapasite - (tam + yarim));
        }
    }
}
