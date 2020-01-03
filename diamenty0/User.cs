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
        public int Wsprx = 200;
        public int Wspry = 200;

        public void moveup()
        {
            Wspy -= 10;
            Wspry = Wspy + 10;
            Wsprx = Wspx;
        }
        public void movedown()
        {
            Wspy += 10;
            Wspry = Wspy - 10;
            Wsprx = Wspx;
        }
        public void moveleft()
        {
            Wspx -= 10;
            Wsprx = Wspx + 10;
            Wspry = Wspy;
        }
        public void moveright()
        {
            Wspx += 10;
            Wsprx = Wspx - 10;
            Wspry = Wspy;
        }
        
    }
}
