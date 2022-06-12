using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class StaticD
    {
        private static int maaslı;
        private int ID { get; set; }

        private int calisanID{ get; set; }
        private string name{ get; set; }
        private string surname { get; set; }
        static int maas { get; set; }
        static StaticD()
        {
            Console.WriteLine("Maaşınız ne kadar???");
            maas = Convert.ToInt32(Console.ReadLine());
        }
        public StaticD(int _ID, string _name, string _surname, int _maas)
        {
            ID= _ID;
            name= _name;
            surname= _surname;
           

        }
        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Maaş: " + maas);
        }
        public static void zamYap(int zamMiktarı)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor...");
            Console.WriteLine("Şuanki maaş: " + (maas + zamMiktarı));
           
        }
    }
}
