using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class Post
    {
        
        public int result = 0;
        public int Points(int levels)
        {
            
            //your code goes here
            for (int i = 0; i <= levels; i++)
            {
                result = result + i;
                
            }
            return result;
         }


}
}
    