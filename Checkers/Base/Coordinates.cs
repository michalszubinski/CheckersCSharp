using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct Coordinates
    {
        internal int x;
        internal int y;

        public Coordinates(int argx, int argy)
        {
            x =argx; y = argy;    
        }

        
        public static Coordinates operator +(Coordinates left, Coordinates right)
        {
            return new Coordinates(left.x + right.x, left.y + right.y);
        }
    }
}
