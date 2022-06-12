using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{

    class Student
    {
        

        private int ogrenciNO;
        private string isim;
        private string soyisim;
        private int vize;
        private int vize2;
        private int final;
        private string okulİsmi;

        public Student(
         int _ogrenciNO,
         string _isim,
         string _soyisim,
         int _vize,
         int _vize2,
         int _final,
         string _okulİsmi)
        {
            ogrenciNO = _ogrenciNO;
            isim = _isim;
            soyisim = _soyisim;
            vize = _vize;
            vize2 = _vize2;
            final = _final;
            okulİsmi = _okulİsmi;

        }
        public void okulGetir()
        {
            Console.WriteLine("Okul ismi:" + okulİsmi);
        }
        public int ogrenciOrtalamaBul()

        {
            
            int a= (vize + vize2 + final) / 3;
            return a;
        }
        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Vize 1: " + vize);
            Console.WriteLine("Vize 2: " + vize2);
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Öğrenci no: " + ogrenciNO);
            Console.WriteLine("Öğrenci adı: " + isim);
            Console.WriteLine("Öğrenci soyisim: " + soyisim);
            
        }
    }
}
