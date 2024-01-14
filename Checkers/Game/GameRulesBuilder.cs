using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.GameAndRules
{
    internal class GameRulesBuilder
    {
        /*
        internal int numberOfTeams = 2;
        internal int startingTeam = 0; // counted from 0
        internal List<Pawn> pawns;
        internal List<Player> players;

        internal int x_boardLowerBoundary = 1;
        internal int y_boardLowerBoundary = 1;
        internal int x_boardUpperBoundary = 8;
        internal int y_boardUpperBoundary = 8;
         */

        int _numberOfTeams;
        int _startingTeam; // counted from 0
        List<Pawn> _pawns;
        List<Player> _players;

        int _x_boardLowerBoundary = 1;
        int _y_boardLowerBoundary = 1;
        int _x_boardUpperBoundary = 8;
        int _y_boardUpperBoundary = 8;

        public GameRulesBuilder() 
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _numberOfTeams = 2;
            _startingTeam = 0; 

            //_pawns = new List<Pawn>;
            //_players = new List<Player>;

            _x_boardLowerBoundary = 1;
            _y_boardLowerBoundary = 1;
            _x_boardUpperBoundary = 8;
            _y_boardUpperBoundary = 8;
        }

        public GameRulesBuilder WithNumberOfTeams(int numberOfTeams)
        {
            _numberOfTeams = numberOfTeams;
            return this;
        }

        public GameRulesBuilder WithStartingTeam(int startingTeam)
        {
            _startingTeam = startingTeam;
            return this;
        }

        public GameRulesBuilder WithAddPawn(Pawn pawn)
        {
            _pawns.Add(pawn);
            return this;
        }

        public GameRulesBuilder WithAddPlayer(Player player)
        {
            _players.Add(player);
            return this;
        }

        public GameRulesBuilder WithXBoardLowerBoundary(int x_boardLowerBoundary)
        {
            _x_boardLowerBoundary += x_boardLowerBoundary;
            return this;
        }
        public GameRulesBuilder WithYBoardLowerBoundary(int y_boardLowerBoundary)
        {
            _y_boardLowerBoundary += y_boardLowerBoundary;
            return this;
        }
        public GameRulesBuilder WithXBoardUpperBoundary(int x_boardUpperBoundary)
        {
            _x_boardUpperBoundary += x_boardUpperBoundary;
            return this;
        }
        public GameRulesBuilder WithYBoardUpperBoundary(int y_boardUpperBoundary)
        {
            _y_boardUpperBoundary += y_boardUpperBoundary;
            return this;
        }

        public GameRules Build() => new GameRules(_numberOfTeams, _startingTeam, _pawns, _players, _x_boardLowerBoundary, _y_boardLowerBoundary, _x_boardUpperBoundary, _y_boardUpperBoundary);

    }
}
