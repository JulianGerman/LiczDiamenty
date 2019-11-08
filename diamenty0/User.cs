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
        public int Wspx = 100;
        public int Wspy = 100;
        public Boolean show = false;

        public void moveup()
        {
            Wspy = Wspy -  18;
            show = true;


        }
        public void movedown()
        {
            Wspy += 18;
            show = true;
        }
        public void moveleft()
        {
            Wspx += 18;
            show = true;
        }
        public void moveright()
        {
            Wspx -= 18;
            show = true;
        }
        
    }
}
