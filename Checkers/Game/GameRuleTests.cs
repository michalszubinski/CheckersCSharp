using Checkers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers.GameAndRules
{
    internal class GameRuleTests
    {
        internal static GameRules getTestMap()
        {
            Pawn pawn1 = new Pawn();
            Pawn pawn2 = new Pawn();

            MoveAbility moveAbility1 = new MoveAbility();

            Player player0 = new PlayerConsole();
            Player player1 = new PlayerConsole();

            //internal Coordinates positionDifference;
            //internal Coordinates attackedPositionDifference;

            //internal bool canAttack;
            //internal bool haveToAttack;
            //
            //internal bool canReplaceExisting;
            //
            //internal bool canScanEnemies;
            //internal bool canScanTeammates;
            //internal bool canSingleScanEnemy;
            //internal bool canSingleScanTeammate;
            //
            //internal bool haveToScanEnemies;
            //internal bool haveToScanTeammates;
            //internal bool haveToSingleScanEnemy;
            //internal bool haveToSingleScanTeammate;
            //
            //internal bool obligatoryIfPossible;
            //internal bool obligatoryWhenCondition;
            //internal bool obligatoryPreventingPlayerChange;

            moveAbility1.canAttack = false;
            moveAbility1.haveToAttack = false;

            moveAbility1.canReplaceExisting = false;

            moveAbility1.canScanEnemies = false;
            moveAbility1.canScanTeammates = false;
            moveAbility1.canScanSingleEnemy = false;
            moveAbility1.canScanSingleTeammate = false;

            moveAbility1.haveToScanEnemies = false;
            moveAbility1.haveToScanTeammates = false;
            moveAbility1.haveToScanSingleEnemy = false;
            moveAbility1.haveToScanSingleTeammate = false;

            moveAbility1.obligatoryIfPossible = false;
            moveAbility1.obligatoryWhenCondition = false;
            moveAbility1.obligatoryPreventingPlayerChange = false;

            MoveAbility moveAbility2 = moveAbility1;
            MoveAbility moveAbility3 = moveAbility1;
            MoveAbility moveAbility4 = moveAbility1;

            moveAbility1.positionDifference = new Coordinates(1, 1);
            moveAbility2.positionDifference = new Coordinates(-1, 1);
            moveAbility3.positionDifference = new Coordinates(-1, -1);
            moveAbility4.positionDifference = new Coordinates(1, -1);

            pawn1.moveAbilities.Add(moveAbility1);
            pawn1.moveAbilities.Add(moveAbility2);
            pawn1.moveAbilities.Add(moveAbility3);
            pawn1.moveAbilities.Add(moveAbility4);

            pawn2 = pawn1;

            pawn1.teamId = 0;
            pawn2.teamId = 1;

            

            GameRules gameRules = new GameRulesBuilder()
                .WithAddPawn(pawn1)
                .WithAddPawn(pawn2)
                .WithAddPlayer(player0)
                .WithAddPlayer(player1)
                .Build();


            return gameRules;
        }
    }
}
