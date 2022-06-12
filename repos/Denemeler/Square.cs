using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    
    public class Square : Shape
    {
        public int kenar;
        public Square(string name, int kenar) : base(name)
        {
            this.kenar = kenar;
        }
        public override void shapeCalc()
        {
            base.shapeCalc();
            Console.WriteLine(getName() + "Karenin alanı: " + kenar * kenar);
        }
        public override void shapeInfo()
        {
            base.shapeInfo();
            Console.WriteLine(getName() + " kenarı:" + this.kenar);
            
            Console.WriteLine(getName() + " şeklin ismi" + getName());
        }
    }
}
