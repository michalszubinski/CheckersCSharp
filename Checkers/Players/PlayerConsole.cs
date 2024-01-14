using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.GameAndRules
{
    internal class PlayerConsole : Player
    {
        internal override Move getMove()
        {
            Move move = new Move(); // delete instantiation later

            try
            {
                Console.WriteLine($"Player {teamId}: {name}");

                Console.WriteLine("Enter coordinates of the pawn you would like to move");
                move.startingPosition.loadTextToCoordinates(Console.ReadLine());

                Console.WriteLine("Enter coordinates where you want to make a move");
                move.endingPosition.loadTextToCoordinates(Console.ReadLine());
            }
            catch (InvalidCastException ex)
            {
                // TODO: log exception
                Console.WriteLine($"ERROR: Wrong input for coordinates: Player {teamId}: {name}");
            }


            return move;
        }
    }
}
