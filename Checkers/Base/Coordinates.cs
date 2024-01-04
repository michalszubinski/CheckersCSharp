using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct Coordinates : IEquatable<Coordinates>
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

        public bool Equals(Coordinates other)
        {
            return (this.x == other.x && this.y == other.y);
        }

        public static bool Equals(Coordinates left, Coordinates right)
        {
            return (left.x == right.x && left.y == right.y);
        }

        public static bool operator==(Coordinates left, Coordinates right)
        {
            return (left.x == right.x && left.y == right.y);
        }

        public static bool operator !=(Coordinates left, Coordinates right)
        {
            return !(left.x == right.x && left.y == right.y);
        }
    }
}
