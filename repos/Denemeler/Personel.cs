using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Personel
    {
        private int ID;
        private string name;
        private string sur;
        private int salary;
        public Personel(int ID, string name, string sur)
        {
            this.ID = ID;
            this.name = name;
            this.sur = sur;
            
        }

        public void PersonelInfo()
        {
            Console.WriteLine("Personel ID: " + this.ID);
            Console.WriteLine("Personel Name: " + this.name);
            Console.WriteLine("Personel Surname: " + this.sur);
            Console.WriteLine("Personel Salary: " + this.salary);
        }


        public int getID()
        {
            return this.ID;
        }
        public void setID(int ID)
        {
            this.ID=ID;
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getSur()
        {
            return this.sur;
        }
        public void setSur(string sur)
        {
            this.sur = sur;
        }
    }
}
