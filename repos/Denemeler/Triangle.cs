using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    internal class Triangle : Shape

    {
        public int taban { get; set; }
        public int height { get; set; }
        public Triangle(string name, int taban, int height) : base(name)
        {
            this.taban = taban;
            this.height = height;
        }
        public override void shapeCalc()
        {
            base.shapeCalc();
            Console.WriteLine(getName()+ " nin alanı: " + (taban * height)/2);
        }
        public override void shapeInfo()
        {
            base.shapeInfo();
            Console.WriteLine(getName() + " taban:" + this.taban);
            Console.WriteLine(getName() + " yükseklik: " + this.height);
            Console.WriteLine(getName() + " şeklin ismi" + getName());
        }
    }
}
