using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericColl
{
    internal class GenericClass<T>
    {
        public T ID { get; set; }
        public static  T Deneme(string v)
        {
            Console.WriteLine("ddenene");
             return default;
        }
    }
}
    
