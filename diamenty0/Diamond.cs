using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamenty0
{
    class Diamond
    {
        public int height = 50;
        public int width = 50;
        public int Wspx;
        public int Wspy;
        public int Imgx;
        public int Imgy;




        public Diamond(int height, int width, int Wspx, int Wspy)
        {
            this.Wspx = Wspx;
            this.Wspy = Wspy;
            this.height = height;
            this.width = width;
            this.Imgx = Wspx + width / 2;
            this.Imgy = Wspy + height / 2;
        }

    }
}
