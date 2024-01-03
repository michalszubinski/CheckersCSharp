using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Pawn
    {
        internal int pawnId;
        internal Coordinates position;
        internal List<MoveAbility> moveAbilities;
        internal string className;
         
        internal int teamId;
        internal int timesMoved;
        internal int killCount;
        
        internal bool isDestroyable;
        internal bool isAttacked;
        internal bool isDefended;
        
        internal bool shouldNotBeAttacked;
        internal bool specialAbilityOnReachingOtherEnd;
        internal bool specialAbilityReached;
    }
}
