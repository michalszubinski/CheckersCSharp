using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Board
    {
        internal List<Pawn> pawns;
        internal int x_LowerBoundary = 0;
        internal int y_LowerBoundary = 0;
        internal int x_UpperBoundary = 8;    
        internal int y_UpperBoundary = 8;
    }
}
