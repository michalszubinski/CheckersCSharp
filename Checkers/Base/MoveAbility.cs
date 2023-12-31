using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct MoveAbility
    {
        internal Coordinates positionChange;
        
        internal bool canReplaceExisting;
        
        internal bool canScanEnemy;
        internal bool canScanTeammate;
        
        internal bool haveToScanEnemy;
        internal bool haveToScanTeammate;
        
        internal bool obligatoryIfPossible;
        internal bool obligatoryWhenCondition;
        internal bool obligatoryPreventingPlayerChange;

        // bool canLeaveBoard;
    }
}
