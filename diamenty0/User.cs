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
        public int Wspx = 50;
        public int Wspy = 50;

        public void moveup()
        {
            Wspy -= 18;
        }
        public void movedown()
        {
            Wspy += 18;
        }
        public void moveleft()
        {
            Wspx += 18;
        }
        public void moveright()
        {
            Wspx -= 18;
        }
        
    }
}
