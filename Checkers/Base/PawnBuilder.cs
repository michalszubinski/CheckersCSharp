using Checkers.GameAndRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class PawnBuilder
    {
        internal int _pawnId;
        internal Coordinates _position;
        internal List<MoveAbility> _moveAbilities;
        internal string _className;
        internal char _asciSymbol;

        internal int _teamId;
        internal int _timesMoved;
        internal int _killCount;

        internal bool _isDestroyable;
        internal bool _isAttacked;
        internal bool _isDefended;

        internal bool _shouldBeProtectedFromAttacks;
        internal bool _specialAbilityOnReachingOtherEnd;
        internal bool _specialAbilityReached;
        internal bool _specialAbilityOnStart;

        public PawnBuilder() 
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            this._pawnId = 0;
            this._position = new Coordinates();
            this._moveAbilities = new List<MoveAbility>();
            this._className = String.Empty;
            this._asciSymbol = '#';
            this._teamId = 0;
            this._timesMoved = 0;
            this._killCount = 0;
            this._isDestroyable = true;
            this._isAttacked = false;
            this._isDefended = false;
            this._shouldBeProtectedFromAttacks = false;
            this._specialAbilityOnReachingOtherEnd = false;
            this._specialAbilityReached = false;
            this._specialAbilityOnStart = false;
        }

        public PawnBuilder WithPawnId(int pawnId)
        {
            this._pawnId = pawnId;
            return this;
        }

        public PawnBuilder WithPosition(Coordinates position)
        {
            this._position = position;
            return this;
        }

        public PawnBuilder WithMoveAbilities(List<MoveAbility> moveAbilities)
        {
            this._moveAbilities = moveAbilities;
            return this;
        }

        public PawnBuilder AddMoveAbility(MoveAbility moveAbility)
        {
            this._moveAbilities.Add(moveAbility);
            return this;
        }

        public PawnBuilder WithClassName(string className)
        {
            this._className = className;
            return this;
        }

        public PawnBuilder WithAsciSymbol(char symbol)
        {
            this._asciSymbol = symbol;
            return this;
        }
        public PawnBuilder WithTeamId(char teamId)
        {
            this._teamId = teamId;
            return this;
        }
        public PawnBuilder WithTimesMoved(char timesMoved)
        {
            this._timesMoved = timesMoved;
            return this;
        }
        public PawnBuilder WithKillCount(char killCount)
        {
            this._killCount = killCount;
            return this;
        }

        public PawnBuilder WithIsDestroyable(bool isDestroyable)
        {
            this._isDestroyable = isDestroyable;
            return this;
        }

        public PawnBuilder WithIsAttacked(bool isAttacked)
        {
            this._isAttacked = isAttacked;
            return this;
        }

        public PawnBuilder WithIsDefended(bool isDefended)
        {
            this._isDefended = isDefended;
            return this;
        }

        public PawnBuilder WithShouldBeProtectedFromAttacks(bool shouldBeProtectedFromAttacks)
        {
            this._shouldBeProtectedFromAttacks = shouldBeProtectedFromAttacks;
            return this;
        }

        public PawnBuilder WithSpecialAbilityOnReachingOtherEnd(bool specialAbilityOnReachingOtherEnd)
        {
            this._specialAbilityOnReachingOtherEnd = specialAbilityOnReachingOtherEnd;
            return this;
        }

        public PawnBuilder WithSpecialAbilityReached(bool specialAbilityReached)
        {
            this._specialAbilityReached = specialAbilityReached;
            return this;
        }

        public PawnBuilder WithSpecialAbilityOnStart(bool specialAbilityOnStart)
        {
            this._specialAbilityOnStart = specialAbilityOnStart;
            return this;
        }

        // SPECIFIC CASES
        public PawnBuilder WithDefaultsOfPawnCheckers()
        {
            /*
            _moveAbilities.Clear();

            MoveAbility moveAbilityForwardLeft = new MoveAbility();
            MoveAbility moveAbilityForwardRight = new MoveAbility();
            
            if (this._teamId == 0)
            {
                moveAbilityForwardLeft.positionDifference = new Coordinates(-1, 1);
                moveAbilityForwardRight.positionDifference = new Coordinates(1, 1);
            }
            else
            {
                moveAbilityForwardLeft.positionDifference = new Coordinates(-1, -1);
                moveAbilityForwardRight.positionDifference = new Coordinates(1, -1);
            }
            */
            //TODO: INSERT MOVES HERE
            this._className = "pawn";
            return this;
        }

        public PawnBuilder WithDefaultsOfQueenCheckers()
        {
            //TODO: INSERT MOVES HERE
            this._className = "queen";
            return this;
        }

        public Pawn Build()
        {
            Pawn pawn = new Pawn(_pawnId, _position, _moveAbilities, _className, _asciSymbol, _teamId, _timesMoved, _killCount, _isDestroyable, _isAttacked, _isDefended, _shouldBeProtectedFromAttacks, _specialAbilityOnReachingOtherEnd, _specialAbilityReached, _specialAbilityOnStart);
            return pawn;
        }
    }
}
