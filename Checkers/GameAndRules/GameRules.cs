using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.GameAndRules
{
    internal class GameRules
    {
        internal int numberOfTeams = 2;
        internal int startingTeam = 0; // counted from 0
        internal List<Pawn> pawns;
        internal List<Player> players;

        internal int x_boardLowerBoundary = 1;
        internal int y_boardLowerBoundary = 1;
        internal int x_boardUpperBoundary = 8;
        internal int y_boardUpperBoundary = 8;

        public GameRules() { }

        public GameRules(int numberOfTeams, int startingTeam, List<Pawn> pawns, List<Player> players, int x_boardLowerBoundary, int y_boardLowerBoundary, int x_boardUpperBoundary, int y_boardUpperBoundary)
        {
            this.numberOfTeams = numberOfTeams;
            this.startingTeam = startingTeam;
            this.pawns = pawns;
            this.players = players;
            this.x_boardLowerBoundary = x_boardLowerBoundary;
            this.y_boardLowerBoundary = y_boardLowerBoundary;
            this.x_boardUpperBoundary = x_boardUpperBoundary;
            this.y_boardUpperBoundary = y_boardUpperBoundary;
        }
    }
}
