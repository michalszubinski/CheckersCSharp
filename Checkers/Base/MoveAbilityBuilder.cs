using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class MoveAbilityBuilder
    {
        internal Coordinates _positionDifference;
        internal Coordinates _attackedPositionDifference;

        internal bool _canAttack;
        internal bool _haveToAttack;
                      
        internal bool _canReplaceExisting;

        internal bool _canScanEnemies;
        internal bool _canScanTeammates;
        internal bool _canScanSingleEnemy;
        internal bool _canScanSingleTeammate;

        internal bool _haveToScanEnemies;
        internal bool _haveToScanTeammates;
        internal bool _haveToScanSingleEnemy;
        internal bool _haveToScanSingleTeammate;

        internal bool _obligatoryIfPossible;
        internal bool _obligatoryWhenCondition;
        internal bool _obligatoryPreventingPlayerChange;

        public MoveAbilityBuilder()
        {
            SetDefaults();
        }

        void SetDefaults()
        {
            this._positionDifference = new Coordinates();
            this._attackedPositionDifference = new Coordinates();
            this._canAttack = false;
            this._haveToAttack = false;
            this._canReplaceExisting = false;
            this._canScanEnemies = false;
            this._canScanTeammates = false;
            this._canScanSingleEnemy = false;
            this._canScanSingleTeammate = false;
            this._haveToScanEnemies = false;
            this._haveToScanTeammates = false;
            this._haveToScanSingleEnemy = false;
            this._haveToScanSingleTeammate = false;
            this._obligatoryIfPossible = false;
            this._obligatoryWhenCondition = false;
            this._obligatoryPreventingPlayerChange = false;
        }

        public MoveAbilityBuilder WithPositionDifference(Coordinates positionDifference)
        {
            this._positionDifference = positionDifference;
            return this;
        }
        public MoveAbilityBuilder WithAttackedPositionDifference(Coordinates attackedPositionDifference)
        {
            this._attackedPositionDifference = attackedPositionDifference;
            return this;
        }        
        public MoveAbilityBuilder WithCanAttack(bool canAttack)
        {
            this._canAttack = canAttack;
            return this;
        }
        public MoveAbilityBuilder WithHaveToAttack(bool haveToAttack)
        {
            this._haveToAttack = haveToAttack;
            return this;
        }
        public MoveAbilityBuilder WithCanReplaceExisting(bool canReplaceExisting)
        {
            this._canReplaceExisting = canReplaceExisting;
            return this;
        }
        public MoveAbilityBuilder WithCanScanEnemies(bool canScanEnemies)
        {
            this._canScanEnemies = canScanEnemies;
            return this;
        }
        public MoveAbilityBuilder WithCanScanTeammates(bool canScanTeammates)
        {
            this._canScanTeammates = canScanTeammates;
            return this;
        }
        public MoveAbilityBuilder WithCanScanSingleEnemy(bool canScanSingleEnemy)
        {
            this._canScanSingleEnemy = canScanSingleEnemy;
            return this;
        }
        public MoveAbilityBuilder WithCanScanSingleTeammate(bool canScanSingleTeammate)
        {
            this._canScanSingleTeammate = canScanSingleTeammate;
            return this;
        }
        public MoveAbilityBuilder WithHaveToScanEnemies(bool haveToScanEnemies)
        {
            this._haveToScanEnemies = haveToScanEnemies;
            return this;
        }
        public MoveAbilityBuilder WithHaveToScanTeammates(bool haveToScanTeammates)
        {
            this._haveToScanTeammates = haveToScanTeammates;
            return this;
        }
        public MoveAbilityBuilder WithHaveToScanSingleEnemy(bool haveToScanSingleEnemy)
        {
            this._haveToScanSingleEnemy = haveToScanSingleEnemy;
            return this;
        }
        public MoveAbilityBuilder WithHaveToScanSingleTeammate(bool haveToScanSingleTeammate)
        {
            this._haveToScanSingleTeammate = haveToScanSingleTeammate;
            return this;
        }
        public MoveAbilityBuilder WithObligatoryIfPossible(bool obligatoryIfPossible)
        {
            this._obligatoryIfPossible = obligatoryIfPossible;
            return this;
        }
        public MoveAbilityBuilder WithObligatoryWhenCondition(bool obligatoryWhenCondition)
        {
            this._obligatoryWhenCondition = obligatoryWhenCondition;
            return this;
        }
        public MoveAbilityBuilder WithObligatoryPreventingPlayerChange(bool obligatoryPreventingPlayerChange)
        {
            this._obligatoryPreventingPlayerChange = obligatoryPreventingPlayerChange;
            return this;
        }
        public MoveAbility Build()
        {
            MoveAbility moveAbility = new MoveAbility(_positionDifference, _attackedPositionDifference, _canAttack, _haveToAttack, _canReplaceExisting, _canScanEnemies, _canScanTeammates, _canScanSingleEnemy, _canScanSingleTeammate, _haveToScanEnemies, _haveToScanTeammates, _haveToScanSingleEnemy, _haveToScanSingleTeammate, _obligatoryIfPossible, _obligatoryWhenCondition, _obligatoryPreventingPlayerChange);
            return moveAbility;
        }




    }
}
