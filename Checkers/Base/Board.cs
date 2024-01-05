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

            moves = checkForObligatoryMoves(moves);

            return moves;
        }

        private List<Move> checkForObligatoryMoves(List<Move> moves)
        {
            var newMoves = new List<Move>();
            bool flag_foundObligatory = false;

            foreach(var move in moves)
            {
                if (move.obligatory)
                {
                    if (!flag_foundObligatory) flag_foundObligatory = true;
                    newMoves.Add(move);
                }
            }

            if (!flag_foundObligatory) return moves;
            else return newMoves;
        }

        private List<Move> generateMovesForSinglePawn(Pawn pawn)
        {
            List<Move> moves = new List<Move>();
            foreach(var moveAbility in pawn.moveAbilities)
            {
                var move = generateMove(moveAbility, pawn);
                move.moveAbility = moveAbility; 
                if(checkIfMoveIsValid(move)) moves.Add( move);
            }

            return moves;
        }

        private bool checkIfMoveIsValid(Move move)
        {
            if (!checkIfCoordinatesAreInsideTheBoard(move.endingPosition)) return false;

            if (!move.moveAbility.canReplaceExisting)
            {
                foreach(var id in move.enemyIds)
                {
                    if (move.endingPosition == pawns[id].position) return false;
                }
                foreach (var id in move.friendlyIds)
                {
                    if (move.endingPosition == pawns[id].position) return false;
                }
            }

            if(!move.moveAbility.canScanEnemies || !move.moveAbility.canScanTeammates)
            {
                if(move.enemyIds.Count > 1 || move.friendlyIds.Count > 1) return false;
                else if(move.enemyIds.Count == 1 || move.friendlyIds.Count == 1)
                {
                    if(!move.moveAbility.canSingleScanTeammate && move.friendlyIds.Count == 1) return false;    
                    if(!move.moveAbility.canSingleScanEnemy && move.enemyIds.Count == 1) return false;    
                }
            }

            if(move.moveAbility.haveToScanEnemies || move.moveAbility.haveToScanTeammates)
            {
                if (move.enemyIds.Count == 0 && move.moveAbility.haveToScanEnemies) return false;
                if (move.friendlyIds.Count == 0 && move.moveAbility.haveToScanTeammates) return false;
            }

            if(move.moveAbility.haveToSingleScanEnemy || move.moveAbility.haveToSingleScanTeammate)
            {
                if (move.moveAbility.haveToSingleScanEnemy && !(move.enemyIds.Count == 1)) return false;
                if (move.moveAbility.haveToSingleScanTeammate && !(move.friendlyIds.Count == 1)) return false;
            }

            if(move.moveAbility.canAttack || move.moveAbility.haveToAttack)
            {
                if (move.moveAbility.haveToAttack && move.enemyIds.Count == 0) return false;
                
                foreach(var enemyId in move.enemyIds)
                {
                    if (!pawns[enemyId].isDestroyable) return false;
                }
            }

            if (move.moveAbility.obligatoryPreventingPlayerChange)
            {
                move.obligatory = true;
            }
            // MOVEABILITY:
            /*

            internal bool canAttack;                        DONE
            internal bool haveToAttack;                     DONE

            internal bool canReplaceExisting;               DONE

            internal bool canScanEnemies;                   DONE
            internal bool canScanTeammates;                 DONE
            internal bool canSingleScanEnemy;               DONE
            internal bool canSingleScanTeammate;            DONE

            internal bool haveToScanEnemies;                DONE
            internal bool haveToScanTeammates;              DONE
            internal bool haveToSingleScanEnemy;            DONE
            internal bool haveToSingleScanTeammate;         DONE

            internal bool obligatoryIfPossible;
            internal bool obligatoryWhenCondition;
            internal bool obligatoryPreventingPlayerChange; DONE

             */

            // PAWN
            /*
            internal bool isDestroyable;
            internal bool isAttacked;
            internal bool isDefended;

            internal bool shouldBeProtectedFromAttacks;
            internal bool specialAbilityOnReachingOtherEnd;
            internal bool specialAbilityReached;
            internal bool specialAbilityOnStart;
             */

            return true;
        }

        private bool checkIfCoordinatesAreInsideTheBoard(Coordinates position)
        {
            /*
            if(position.x < x_LowerBoundary) return false;   
            if(position.y < y_LowerBoundary) return false;   
            if(position.x > x_UpperBoundary) return false;   
            if(position.y > x_UpperBoundary) return false;   

            return true;
            */
            return position.x >= x_LowerBoundary &&
                   position.y >= y_LowerBoundary &&
                   position.x <= x_UpperBoundary &&
                   position.y <= x_UpperBoundary ? true : false;
        }

        private Move generateMove(MoveAbility moveAbility, Pawn pawn)
        {
            Move move = new Move();

            move.startingPosition = pawn.position;
            move.endingPosition = pawn.position + moveAbility.positionDifference;
            move.moveAbility = moveAbility;

            move = scanForPawns(move,pawn);

            return move;
        }

        private Move scanForPawns(Move move, Pawn pawn) // TODO
        { 
            if(Math.Abs(move.moveAbility.positionDifference.x) == Math.Abs(move.moveAbility.positionDifference.y))
            {
                for(int i = 0; i < Math.Abs(move.moveAbility.positionDifference.x); ++i)
                {
                    // CLEAN THIS LATER
                    Pawn tempPawn = getPawnAtCoordinates(new Coordinates(
                        move.startingPosition.x + i * ((move.moveAbility.positionDifference.x)/ Math.Abs(move.moveAbility.positionDifference.x)),
                        move.startingPosition.y + i * ((move.moveAbility.positionDifference.y) / Math.Abs(move.moveAbility.positionDifference.y))));

                    if (tempPawn == null) continue;

                    if (pawn.teamId == tempPawn.teamId) move.friendlyIds.Add(tempPawn.teamId);
                    else if (pawn.teamId != tempPawn.teamId) move.enemyIds.Add(tempPawn.teamId);
                }
            }
            else
            { // TODO
                throw new NotImplementedException(); 
            }

            return move;
        }

        private Pawn getPawnAtCoordinates(Coordinates coordinates) // CAN THROW
        {
            foreach(var pawn in pawns)
            {
                if (pawn.position == coordinates) return pawn;
            }

            //throw new Exception("Checkers.Base.Board.getPawnAtCoordinates(Coordinates coordinates) -> PAWN NOT FOUND. Use try-catch on the method.");
            return null;
        }

        public bool checkIfObligatoryPreventingPlayerChangeExists(List<Move> moves)
        {
            foreach(var move in moves)
            {
                if(move.moveAbility.obligatoryPreventingPlayerChange) return true;
            }

            return false;
        }
    }
}
