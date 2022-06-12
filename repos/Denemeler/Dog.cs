using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    public class Dog:Hayvan
    {
        

        public Dog(string name):base(name)
        {

        }
        public override void speak()
        {
            Console.WriteLine(getName() + " Havlıyor lan");
    }
    }
    
}


//public int ExpectedMinutesInOven()
//{
//    int expected = 40;
//    return expected;
//}


//// TODO: define the 'RemainingMinutesInOven()' method
//public int RemainingMinutesInOven(int remain)
//{

//    return ExpectedMinutesInOven() - remain;
//}