using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct MoveAbility : ICloneable
    {
        internal Coordinates positionDifference;
        internal Coordinates attackedPositionDifference;

        internal bool canAttack;
        internal bool haveToAttack;
        
        internal bool canReplaceExisting;
        
        internal bool canScanEnemies;
        internal bool canScanTeammates;
        internal bool canScanSingleEnemy;
        internal bool canScanSingleTeammate;

        internal bool haveToScanEnemies;
        internal bool haveToScanTeammates;
        internal bool haveToScanSingleEnemy;
        internal bool haveToScanSingleTeammate;

        internal bool obligatoryIfPossible;
        internal bool obligatoryWhenCondition;
        internal bool obligatoryPreventingPlayerChange;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // bool canLeaveBoard;
    }
}
