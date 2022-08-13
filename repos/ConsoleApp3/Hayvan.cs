using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hayvan
    {
        public string name;
        public string cinsiyet;
        public string renk;


        public Hayvan(string name)
        {
            this.name = name;
        }
        
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        { 
            this.name = name;
        }
        public virtual void speak()
        {
            Console.WriteLine("Hayvan konuştu.");
        }
    } 
    
}


