using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class MoveAbility : ICloneable
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

        public MoveAbility()
        {
            this.positionDifference = new Coordinates();
            this.attackedPositionDifference = new Coordinates();
            this.canAttack = false;
            this.haveToAttack = false;
            this.canReplaceExisting = false;
            this.canScanEnemies = false;
            this.canScanTeammates = false;
            this.canScanSingleEnemy = false;
            this.canScanSingleTeammate = false;
            this.haveToScanEnemies = false;
            this.haveToScanTeammates = false;
            this.haveToScanSingleEnemy = false;
            this.haveToScanSingleTeammate = false;
            this.obligatoryIfPossible = false;
            this.obligatoryWhenCondition = false;
            this.obligatoryPreventingPlayerChange = false;
        }
        public MoveAbility(Coordinates positionDifference, Coordinates attackedPositionDifference, bool canAttack, bool haveToAttack, bool canReplaceExisting, bool canScanEnemies, bool canScanTeammates, bool canScanSingleEnemy, bool canScanSingleTeammate, bool haveToScanEnemies, bool haveToScanTeammates, bool haveToScanSingleEnemy, bool haveToScanSingleTeammate, bool obligatoryIfPossible, bool obligatoryWhenCondition, bool obligatoryPreventingPlayerChange)
        {
            this.positionDifference = positionDifference;
            this.attackedPositionDifference = attackedPositionDifference;
            this.canAttack = canAttack;
            this.haveToAttack = haveToAttack;
            this.canReplaceExisting = canReplaceExisting;
            this.canScanEnemies = canScanEnemies;
            this.canScanTeammates = canScanTeammates;
            this.canScanSingleEnemy = canScanSingleEnemy;
            this.canScanSingleTeammate = canScanSingleTeammate;
            this.haveToScanEnemies = haveToScanEnemies;
            this.haveToScanTeammates = haveToScanTeammates;
            this.haveToScanSingleEnemy = haveToScanSingleEnemy;
            this.haveToScanSingleTeammate = haveToScanSingleTeammate;
            this.obligatoryIfPossible = obligatoryIfPossible;
            this.obligatoryWhenCondition = obligatoryWhenCondition;
            this.obligatoryPreventingPlayerChange = obligatoryPreventingPlayerChange;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // bool canLeaveBoard;
    }
}
