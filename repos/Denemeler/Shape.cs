using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Shape
    {
        public string name { get; set; }
        public Shape(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public virtual void shapeCalc()
        {
            Console.WriteLine( "Şeklin alanı hesaplanıyor..." );
        }
        public virtual void shapeInfo()
        {
            Console.WriteLine(getName + "nin bilgileri ");
        }
        public string Rat
        {
            get
            {
                return name;
            }
            set
            {

            }
        }
    }

}
