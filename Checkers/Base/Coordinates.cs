using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        
        public static List<Coordinates> textToCoordinatesList(string text) // CAN THROW 'InvalidCastException'
        {
            List<Coordinates> cordList = new List<Coordinates>();

            MatchCollection matches = Regex.Matches(text, $"[a-z][1-9]", RegexOptions.Singleline);

            if (matches.Count == 0) throw new InvalidCastException("ERROR: List<Coordinates> Coordinates.textToCoordinatesList(string): No matches for given text");

            foreach (Match match in matches)
            {
                Coordinates temp = textToCoordinates_coordinatesFromMatch(match);
                cordList.Add(temp);
            }

            return cordList;
        }

        public void loadTextToCoordinates(string text) // CAN THROW 'InvalidCastException'
        {
            //TODO: Expand functionality beyond [a-z][1-9]
            //TODO: Add support for multiple character x coordinates, for example: aaaaaaaa4
            //TODO: Add support for multiple character y coordinates, for example: f12
            //TODO: Add support to reverse coordinates, for example: 4g
            //TODO: Accept input with spaces, for example: 'c 4';  ' c4'; 'c4 '
            //TODO: Support uppercase characters
            //TODO: Return list of coordinates

            MatchCollection matches = Regex.Matches(text, $"[a-z][1-9]", RegexOptions.Singleline);

            if (matches.Count == 0) throw new InvalidCastException("ERROR: void Coordinates.loadTextToCoordinates(string): No matches for given text");

            Coordinates temp = textToCoordinates_coordinatesFromMatch(matches[0]);
            this.x = temp.x;
            this.y = temp.y;
        }

        private static Coordinates textToCoordinates_coordinatesFromMatch(Match match)
        {
            Coordinates temp = new Coordinates();

            int.TryParse((match.Value[0] - 'a' + 1).ToString(), out temp.x); // idk about this +1; should be conditional, depending on the board borders
            int.TryParse(match.Value[1].ToString(), out temp.y);

            //temp.x -= 97;

            return temp;
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

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
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
