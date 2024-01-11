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
            string temp;
            Move move = new Move(); // delete instantiation later

            try
            {
                Console.WriteLine($"Player {teamId}: {name}");

                Console.WriteLine("Enter coordinates of the pawn you would like to move");
                temp = Console.ReadLine(); // build the method in coordinates 

                Console.WriteLine("Enter coordinates where you want to make a move");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Wrong input for coordinates: Player {teamId}: {name}");
            }


            return move;
        }
    }
}
