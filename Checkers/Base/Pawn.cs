using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Pawn : ICloneable
    {
        internal int pawnId;
        internal Coordinates position;
        internal List<MoveAbility> moveAbilities;
        internal string className;
        internal char asciSymbol;
         
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
            this.asciSymbol = '#';
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

        public Pawn(int pawnId, Coordinates position, List<MoveAbility> moveAbilities, string className, char asciSymbol, int teamId, int timesMoved, int killCount, bool isDestroyable, bool isAttacked, bool isDefended, bool shouldBeProtectedFromAttacks, bool specialAbilityOnReachingOtherEnd, bool specialAbilityReached, bool specialAbilityOnStart)
        {
            this.pawnId = pawnId;
            this.position = position;
            this.moveAbilities = moveAbilities;
            this.className = className;
            this.asciSymbol = asciSymbol;
            this.teamId = teamId;
            this.timesMoved = timesMoved;
            this.killCount = killCount;
            this.isDestroyable = isDestroyable;
            this.isAttacked = isAttacked;
            this.isDefended = isDefended;
            this.shouldBeProtectedFromAttacks = shouldBeProtectedFromAttacks;
            this.specialAbilityOnReachingOtherEnd = specialAbilityOnReachingOtherEnd;
            this.specialAbilityReached = specialAbilityReached;
            this.specialAbilityOnStart = specialAbilityOnStart;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
