using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkers.Base;
using Checkers.Workers;

namespace Checkers.GameAndRules
{
    internal class GameManager
    {
        internal int currentTurn_team;
        internal Board board;
        internal GameRules gameRules;
        internal List<Player> players;

        //GAME
        List<Move> possibleMoves = new List<Move>(); // current moves available to active player
        bool isTheMovePossible = false; // is the move possible
        Move attemptedMove = new Move();

        public void startGame() // TODO
        {
            setGameRules("default");

            while (true) // Game loop
            {
                beforeMakeMove(); // clean-up, generates moves available to player
                do // Turn loop
                {
                    CheckersConsoleBoardDisplayer.Display(board);
                    isTheMovePossible = makeMove();

                } while (!isTheMovePossible);
                afterMakeMove(); // applies the move, switches the team the terms are right
            }
        }

        void setGameRules(string ruleSetName)
        {
            var gameRules = getGameRules( ruleSetName.ToLower() );
            applyGameRules(gameRules);
        }

        private void afterMakeMove()
        {
            applyMove();
            decidePlayersTurn();
        }

        bool makeMove()
        {
            attemptedMove = players[currentTurn_team].getMove();

            Pawn tempPawn = board.getPawnAtCoordinates(attemptedMove.startingPosition);
            if (tempPawn == null) return false;

            attemptedMove.pawnId = tempPawn.pawnId;

            foreach (var move in possibleMoves)
            {
                if (attemptedMove.startingPosition == move.startingPosition && attemptedMove.endingPosition == move.endingPosition
                    && attemptedMove.pawnId == move.pawnId)
                    return true;
            }

            return false;
        }

        void decidePlayersTurn()
        {
            if (!checkForObligatoryPreventingPlayerChange())
            {
                switchTeam();
            }
        }

        bool checkForObligatoryPreventingPlayerChange() // TODO
        {
            return board.checkIfObligatoryPreventingPlayerChangeExists(possibleMoves);
        }

        void beforeMakeMove()
        {
            afterTurnClearUp();
            possibleMoves = getAllMoves(board, currentTurn_team);
        }

        void applyMove()
        {
            board.applyMove(attemptedMove);
        }

        void afterTurnClearUp()
        {
            possibleMoves.Clear();
            isTheMovePossible = false;
        }

        List<Move> getAllMoves(Board board, int teamId) 
        {
            return board.generateAllMoves(teamId);
        }
        void applyGameRules(GameRules argGameRules)  // TODO
        {
            gameRules = GameRuleTests.getTestMap(); // REPLACE THIS

            //imported from gameRules
            board = new Board(); // put this in a different place

            board.pawns = gameRules.pawns;
            this.players = gameRules.players;

            board.x_LowerBoundary = gameRules.x_boardLowerBoundary;
            board.y_LowerBoundary = gameRules.y_boardLowerBoundary;
            board.x_UpperBoundary = gameRules.x_boardUpperBoundary;
            board.y_UpperBoundary = gameRules.y_boardUpperBoundary;

            this.currentTurn_team = gameRules.startingTeam;
            // gameRules.numberOfTeams;
    }
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
