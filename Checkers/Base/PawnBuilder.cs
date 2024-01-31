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
        public PawnBuilder WithDefaultsOfPawnCheckers(int teamId)
        {
            this._teamId = teamId;

            // CREATING AND ADDING MOVEABILITIES
            int movementDirectionCoefficient = 1;
            if( teamId == 1)
            {
                movementDirectionCoefficient = -1;
            }

            // BASIC MOVES
            MoveAbility moveAbilityLeft = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(-1, 1 * movementDirectionCoefficient))
                .Build();

            MoveAbility moveAbilityRight = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(1, 1*movementDirectionCoefficient))
                .Build();

            // ATTACKING MOVES
            MoveAbility moveAbilityAttackLeftUp = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(-2, 2))
                .WithCanAttack(true)
                .WithHaveToAttack(true)
                .WithObligatoryPreventingPlayerChange(true)
                .WithAttackedPositionDifference(new Coordinates(-1, 1))
                .Build();

            MoveAbility moveAbilityAttackRightUp = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(2, 2))
                .WithCanAttack(true)
                .WithHaveToAttack(true)
                .WithObligatoryPreventingPlayerChange(true)
                .WithAttackedPositionDifference(new Coordinates(1, 1))
                .Build();

            MoveAbility moveAbilityAttackLeftDown = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(-2, -2))
                .WithCanAttack(true)
                .WithHaveToAttack(true)
                .WithObligatoryPreventingPlayerChange(true)
                .WithAttackedPositionDifference(new Coordinates(-1, -1))
                .Build();

            MoveAbility moveAbilityAttackRightDown = new MoveAbilityBuilder()
                .WithPositionDifference(new Coordinates(2, -2))
                .WithCanAttack(true)
                .WithHaveToAttack(true)
                .WithObligatoryPreventingPlayerChange(true)
                .WithAttackedPositionDifference(new Coordinates(1, -1))
                .Build();

            // ADDING MOVES TO THE MOVE ABILITY LIST
            _moveAbilities.Add(moveAbilityLeft);
            _moveAbilities.Add(moveAbilityRight);
            _moveAbilities.Add(moveAbilityAttackLeftUp);
            _moveAbilities.Add(moveAbilityAttackRightUp);
            _moveAbilities.Add(moveAbilityAttackRightDown);
            _moveAbilities.Add(moveAbilityAttackRightUp);

            this._className = "pawn";
            return this;
        }

        public PawnBuilder WithDefaultsOfQueenCheckers(int teamId, int maxBoardDimension)
        {
            this._teamId = teamId;
            //TODO: INSERT MOVES HERE

            // BASIC MOVES
            for(int i = 1; i <= maxBoardDimension; i++) // RANGE
            {
                for(int j = 1; j > -3; j-=2)            // RIGHT OR LEFT
                {
                    for (int k = 1; k > -3; k -= 2)    // UP OR DOWN
                    {
                        MoveAbility moveAbilityBasic = new MoveAbilityBuilder()
                            .WithPositionDifference(new Coordinates(i*j,i*k))
                            .Build();

                        _moveAbilities.Add(moveAbilityBasic); // ADDING MOVES TO THE MOVE ABILITY LIST
                    }
                }
            }

            // ATTACKING MOVES
            for (int i = 1; i <= maxBoardDimension; i++) // RANGE
            {
                for (int j = 1; j > -3; j -= 2)            // RIGHT OR LEFT
                {
                    for (int k = 1; k > -3; k -= 2)    // UP OR DOWN
                    {
                        MoveAbility moveAbilityBasic = new MoveAbilityBuilder()
                            .WithPositionDifference(new Coordinates(i * j, i * k))
                            .WithCanScanEnemies(true)
                            .WithAttackedPositionDifference(new Coordinates(i * j - 1*j, i * k - 1*k)) // add check in method that checks the viability of the move if the pawn is here
                            .Build();

                        _moveAbilities.Add(moveAbilityBasic); // ADDING MOVES TO THE MOVE ABILITY LIST
                    }
                }
            }


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
