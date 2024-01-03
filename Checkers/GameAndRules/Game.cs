﻿using System;
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

        //GAME
        List<Move> moves = new List<Move>(); // current moves available to active player
        bool isTheMovePossible = false; // is the move possible
        Move requestedMove = new Move();

        void startGame() // TODO
        {
            setGameRules("default");

            while (true) // Game loop
            {
                beforeMakeMove(); // clean-up, generates moves available to player
                do // Turn loop
                {
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
            switch (gameRules.players[currentTurn_team].inputType)
            {
                case "default":
                    return true;
            }
            return true;
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
            return false;
        }

        void beforeMakeMove()
        {
            afterTurnClearUp();
            moves = getAllMoves(board, currentTurn_team);
        }

        void applyMove()
        {
            throw new NotImplementedException();
        }

        void afterTurnClearUp()
        {
            moves.Clear();
            isTheMovePossible = false;
        }

        List<Move> getAllMoves(Board board, int teamId) 
        {
            return board.generateAllMoves(teamId);
        }
        void applyGameRules(GameRules gameRules) {}
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
