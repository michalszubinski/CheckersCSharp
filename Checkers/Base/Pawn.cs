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
        
        internal bool shouldBeProtectedFromAttacks;
        internal bool specialAbilityOnReachingOtherEnd;
        internal bool specialAbilityReached;
        internal bool specialAbilityOnStart;

        public Pawn()
        {
            this.pawnId = 0;
            this.position = new Coordinates();
            this.moveAbilities = new List<MoveAbility>();
            this.className = String.Empty;
            this.teamId = 0;
            this.timesMoved = 0;
            this.killCount = 0;
            this.isDestroyable = true;
            this.isAttacked = false;
            this.isDefended = false;
            this.shouldBeProtectedFromAttacks = false;
            this.specialAbilityOnReachingOtherEnd = false;
            this.specialAbilityReached = false;
            this.specialAbilityOnStart = false;
        }
    }
}
