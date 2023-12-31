using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Base;

namespace Checkers.GameAndRules
{
    internal class Game
    {
        internal int currentTurn_team;
        internal Board board;
        internal GameRules gameRules;

        void startGame() // TODO
        {
            var gameRules = getGameRules("default");
            applyGameRules(gameRules);
            List<Move> moves = new List<Move>();


            while (true) // Game loop
            {
                moves.Clear();
                moves = getAllMoves(board,currentTurn_team);
                do // Turn loop
                {


                } while (true);
            }
        }
        List<Move> getAllMoves(Board board, int teamId) 
        {
            List<Move> moves = new List<Move>();
            List<Move> temp = new List<Move>();
            foreach (var pawn in board.pawns)
            {
                if (pawn.teamId == teamId)
                {
                    moves += getMoveForSinglePawn(board, pawn);
                }
            }

            return moves;
        }
        List<Move> getMoveForSinglePawn(Board board, Pawn pawn) // rethink
        {
            List<Move> moves = new List<Move>;

            foreach(var moveAbility in pawn.moveAbilities)
            {
                Move temp = new Move();

                // CHECK IN MOVE IF THE MOVEABILITY IS POSSIBLE
            }

            return moves;
        }
        void removePawn() { }
        void applyGameRules(GameRules gameRules) {}
        bool checkIfMoveAbilityIsPossible(MoveAbility argMoveAbility) { return true; }
        GameRules getGameRules(string ruleSet) // TODO
        {
            GameRules temp = new GameRules();  
            return temp; 
        }
        void switchTeam()
        {
            currentTurn_team++;
            if(currentTurn_team >= gameRules.numberOfTeams) 
            {
                currentTurn_team = 0;
            }
        }
    }
}
