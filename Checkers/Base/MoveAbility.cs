using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct MoveAbility
    {
        internal Coordinates positionDifference;
        internal Coordinates attackedPositionDifference;

        internal bool canAttack;
        internal bool haveToAttack;
        
        internal bool canReplaceExisting;
        
        internal bool canScanEnemies;
        internal bool canScanTeammates;
        internal bool canSingleScanEnemy;
        internal bool canSingleScanTeammate;

        internal bool haveToScanEnemies;
        internal bool haveToScanTeammates;
        internal bool haveToSingleScanEnemy;
        internal bool haveToSingleScanTeammate;

        internal bool obligatoryIfPossible;
        internal bool obligatoryWhenCondition;
        internal bool obligatoryPreventingPlayerChange;

        // bool canLeaveBoard;
    }
}
