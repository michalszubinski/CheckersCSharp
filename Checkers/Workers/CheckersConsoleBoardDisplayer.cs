using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.Workers
{
    internal class CheckersConsoleBoardDisplayer
    {
        internal static void Display(Board board) // TODO: Flip the board
        {
            for(int col = board.y_UpperBoundary; col >= board.y_LowerBoundary; col--)
            { 
                Console.Write($"{col} ");
                for (int row = board.x_LowerBoundary; row <= board.x_UpperBoundary; row++)
                {
                    var tempPawn = board.getPawnAtCoordinates(new Coordinates(row, col));
                    if(tempPawn == null) Console.Write("  ");
                    else if(tempPawn.teamId == 0 && tempPawn.className == "queen") Console.Write("O "); // do check if is queen better way
                    else if(tempPawn.teamId == 1 && tempPawn.className == "queen") Console.Write("X ");
                    else if(tempPawn.teamId == 0) Console.Write("o ");
                    else if(tempPawn.teamId == 1) Console.Write("x ");
                }
            }

            for (int row = 0; row <= board.x_UpperBoundary - board.x_LowerBoundary; row++) Console.Write($"  {(char)(row+97)}");
        }
    }
}

/*
8
7
6
5
4
3
2
1 
  a  b  c  d  e  f  g  h

o - White pawn
x - Black pawn
O - White queen
X - Black queen
 */