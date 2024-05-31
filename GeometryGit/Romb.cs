using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Romb
    {
        Fdata fd;
        public double a
        {
            get => fd.a;
            set => fd.a = value;
        }

        public double b
        {
            get => fd.b;
            set => fd.b = value;
        }

        public double Area()
        {
            return (a * 2 + b * 2) / 2.0; 
        }

        public Romb(Fdata fd)
        {
            this.fd = fd;
            fd.type = Figures.Romb;
        }

        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }

        public void PrintInfo()
        {
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" a=" + a + " b=" + b);
        }
    }
}
