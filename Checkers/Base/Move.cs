using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Move
    {
        Coordinates startingPosition;
        Coordinates endingPosition;
        MoveAbility moveAbility;
        bool allowed;
    }
}
