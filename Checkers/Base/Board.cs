using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Board
    {
        List<Pawn> pawns;
        int x_LowerBoundary = 0;
        int y_LowerBoundary = 0;
        int x_UpperBoundary = 8;    
        int y_UpperBoundary = 8;
    }
}
