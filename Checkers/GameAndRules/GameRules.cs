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
        internal int numberOfTeams;
        internal int startingTeam; // counted from 0
        internal List<Pawn> pawns;
        internal List<Player> players;

        internal int x_boardLowerBoundary = 0;
        internal int y_boardLowerBoundary = 0;
        internal int x_boardUpperBoundary = 8;
        internal int y_boardUpperBoundary = 8;

        public GameRules() { }
    }
}
