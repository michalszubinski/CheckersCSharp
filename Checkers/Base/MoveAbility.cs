using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal struct MoveAbility
    {
        Coordinates positionChange;

        bool canReplaceExisting;

        bool canScanEnemy;
        bool canScanTeammate;

        bool haveToScanEnemy;
        bool haveToScanTeammate;

        bool obligatoryIfPossible;
        bool obligatoryWhenCondition;

        // bool canLeaveBoard;
    }
}
