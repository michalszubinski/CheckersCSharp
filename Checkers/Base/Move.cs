using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Move
    {
        internal Coordinates startingPosition;
        internal Coordinates endingPosition;
        internal MoveAbility moveAbility;
        internal bool allowed;

        internal int pawnId;
        internal List<int> enemyIds;
        internal List<int> friendlyIds;
    }
}
