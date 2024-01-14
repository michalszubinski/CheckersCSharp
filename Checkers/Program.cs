using Checkers.GameAndRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WORK IN PROGRESS

// TODO:
/*
 * Rethink namespace and folder structure
 * Rethink GameRules creating structure
 * Rethink Pawn structure - maybe inheriting?
 * Add Builders for MoveAbility and Pawn?
 * Write board viewer in console
 * Improve encapsulation
 * Add Unit Testing
 * Allow unit testing through InternalsVisibleTo
 * Add AI
 * Add move conditions that allow to play chess
 * 
*/

namespace Checkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            game.startGame();
        }
    }
}
