using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamenty0
{
    class User
    {
        public int height = 50;
        public int width = 50;
        public int Wspx = 200;
        public int Wspy = 200;
        

        public void moveup()
        {
            Wspy = Wspy -  10;
           


        }
        public void movedown()
        {
            Wspy += 10;
            
        }
        public void moveleft()
        {
            Wspx -= 10;
            
        }
        public void moveright()
        {
            Wspx += 10;
            
        }
        
    }
}
