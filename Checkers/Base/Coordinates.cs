using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static List<Coordinates> textToCoordinates(string text) // CAN THROW 'InvalidCastException'
        {
            List<Coordinates> cordList = new List<Coordinates>();

            //TODO: Expand functionality beyond [a-z][1-9]
            //TODO: Add support for multiple character x coordinates, for example: aaaaaaaa4
            //TODO: Add support for multiple character y coordinates, for example: f12
            //TODO: Add support to reverse coordinates, for example: 4g
            //TODO: Accept input with spaces, for example: 'c 4';  ' c4'; 'c4 '
            //TODO: Support uppercase characters
            //TODO: Return list of coordinates

            MatchCollection matches = Regex.Matches(text, $"[a-z][1-9]", RegexOptions.Singleline);

            if (matches.Count == 0) throw new InvalidCastException("ERROR: Coordinates.textToCoordinates(string): No matches for given text");

            foreach (Match match in matches)
            {
                Coordinates temp = new Coordinates();
                int.TryParse(match.Value[0], out temp.x); // TODO
                int.TryParse(match.Value[1], out temp.y); // TODO

                cordList.Add(temp);
            }

            return cordList;
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
