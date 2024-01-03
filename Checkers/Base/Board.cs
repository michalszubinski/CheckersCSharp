using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Base
{
    internal class Board
    {
        internal List<Pawn> pawns;
        internal int x_LowerBoundary = 1;
        internal int y_LowerBoundary = 1;
        internal int x_UpperBoundary = 8;    
        internal int y_UpperBoundary = 8;

        internal List<Move> generateAllMoves(int argTeamID)
        {
            List<Move> moves = new List<Move>();
            List<Move> temp = new List<Move>();
            foreach (var pawn in pawns)
            {
                if (pawn.teamId == argTeamID)
                {
                    moves.AddRange(generateMovesForSinglePawn(pawn));
                }
            }

            return moves;
        }

        private List<Move> generateMovesForSinglePawn(Pawn pawn)
        {
            List<Move> moves = new List<Move>();
            foreach(var moveAbility in pawn.moveAbilities)
            {
                var move = generateMove(moveAbility, pawn);
                if(checkIfMoveIsValid(move)) moves.Add( move);
            }
            return moves;
        }

        private bool checkIfMoveIsValid(Move move)
        {
            if (!checkIfCoordinatesAreInsideTheBoard(move.endingPosition)) return false;


            // MOVEABILITY:
            /*
            internal bool canReplaceExisting;
        
            internal bool canScanEnemy;
            internal bool canScanTeammate;
        
            internal bool haveToScanEnemy;
            internal bool haveToScanTeammate;
        
            internal bool obligatoryIfPossible;
            internal bool obligatoryWhenCondition;
            internal bool obligatoryPreventingPlayerChange;
             */

            // PAWN
            /*
            internal bool isDestroyable;
            internal bool isAttacked;
            internal bool isDefended;
        
            internal bool shouldNotBeAttacked;
            internal bool specialAbilityOnReachingOtherEnd;
            internal bool specialAbilityReached;
             */

            return true;
        }

        private bool checkIfCoordinatesAreInsideTheBoard(Coordinates position)
        {
            if(position.x < x_LowerBoundary) return false;   
            if(position.y < y_LowerBoundary) return false;   
            if(position.x > x_UpperBoundary) return false;   
            if(position.y > x_UpperBoundary) return false;   

            return true;
        }

        private Move generateMove(MoveAbility moveAbility, Pawn pawn)
        {
            Move move = new Move();

            move.startingPosition = pawn.position;
            move.endingPosition = pawn.position + moveAbility.positionChange;

            move.enemyIds = scanForEnemyPawns();

            return move;
        }

        private List<int> scanForEnemyPawns() // TODO
        {
            List<int> enemyPawnsIds = new List<int>();  

            // TODO

            return enemyPawnsIds;
        }
    }
}
