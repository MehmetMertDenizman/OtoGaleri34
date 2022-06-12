using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    class KapsulOdev
    {
        private string tck;
        public string tc
        {
            get
            {
                
                 
                 
                
                 
                return tck;
            }
            set
            {
               
                tck = value;
                bool sayıMi = false;



                char[] arraya = tck.Take(5).ToArray();
                

                if (tck.Length == 11)
                    {
                        Console.WriteLine("11 tc hane");
                    for (int i = 0; i < value.Length; i++)
                        {
                            sayıMi =   char.IsNumber(value[i]);
                        if (sayıMi == false)
                        {
                            Console.WriteLine("RAKAM DEĞİL");
                        }
                    }
                    
                }
                    else
                        { 
                        
                        Console.WriteLine("11 değil");
                        
                        }

                Console.WriteLine(arraya);
            }
        }
        public static void anan()
        {
            Console.WriteLine("ananana");
        }
    }
}
