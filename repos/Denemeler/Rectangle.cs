using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Rectangle:Shape
    {
        public int smallEdge { get; set; }
        public int longEdge { get; set; }
        public Rectangle(string name, int longEdge, int smallEdge) : base(name)
        {
            this.longEdge = longEdge;
            this.name = name;
            this.smallEdge = smallEdge;
        }
        public override void shapeCalc()
        {
            base.shapeCalc();
            Console.WriteLine(getName() + " nin alanı: " + (smallEdge * longEdge));
        }
        public override void shapeInfo()
        {
            base.shapeInfo();
            Console.WriteLine(getName() + " kısa kenar:" + this.smallEdge);
            Console.WriteLine(getName() + " uzun kenar: " + this.longEdge);
            Console.WriteLine(getName() + " şeklin ismi" + getName());


        }
    }
}
