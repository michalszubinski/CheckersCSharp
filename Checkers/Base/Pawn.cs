using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Pawn
    {
        Coordinates position;
        List<MoveAbility> allowedMoves;

        int teamId;

        bool isDestroyable;
        bool isAttacked;
        bool isDefended;
    }
}
