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
        int currentTurn_team;
        Board board;

        void startGame() { }
        void getAllMoves() { }
        void getMoveForSinglePawn() { }
        void removePawn() { }
        void applyGameRules() { }
        bool checkIfMoveAbilityIsPossible(MoveAbility argMoveAbility) { return true; }
    }
}
