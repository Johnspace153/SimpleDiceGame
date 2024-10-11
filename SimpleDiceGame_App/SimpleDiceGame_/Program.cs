

using DiceGameLibrary.Models;
using SimpleDiceGame_;

PlayerModel activePlayer = new PlayerModel();
PlayerModel aiOpponent = new PlayerModel();

"Welcome to my SimpleDiceGame App ".PrintToConsole();
Console.WriteLine();
activePlayer.UserName = "Please give us your Username: ".RequestString();
Console.WriteLine();
aiOpponent.UserName = "Opponent";

int rounds = "How many rounds do you want to play: ".RequestNumber();
Console.WriteLine();

List<int> actList = activePlayer.RollMyDice(10);
List<int> oppList = aiOpponent.RollMyDice(10);

RoundPlay();

Console.ReadLine();

void RoundPlay()
{
    for (int i = 0; i < rounds; i++)
    {
        "Press the ENTER key to roll the dice".PrintToConsole();
        Console.ReadKey();
        $"{activePlayer.UserName} rolled a {actList[i]}".PrintToConsole();
        Console.WriteLine();
        "......".PrintToConsole();
        $"{aiOpponent.UserName} rolled a {oppList[i]}".PrintToConsole();
        Console.WriteLine();

        if (actList[i] > oppList[i])
        {
            $"{activePlayer.UserName} wins this round!".PrintToConsole();
            activePlayer.TotalScore++;
        }
        else if(actList[i] < oppList[i])
        {
            $"{aiOpponent.UserName} wins this round!".PrintToConsole();
            aiOpponent.TotalScore++;

        }
        else
        {
            "This Round is a DRAW".PrintToConsole();
        }
        $"SCORE:-{activePlayer.UserName} : {activePlayer.TotalScore}- -{aiOpponent.UserName} : {aiOpponent.TotalScore}-".PrintToConsole();
        Console.WriteLine();
    }

    if (activePlayer.TotalScore > aiOpponent.TotalScore)
    {
        $"{activePlayer.UserName} Wins".PrintToConsole();
        
    }
    else if ( activePlayer.TotalScore < aiOpponent.TotalScore)
    {
        $"{aiOpponent.UserName} Wins".PrintToConsole();

    }
    else if(activePlayer.TotalScore == aiOpponent.TotalScore)
    {
        $"It is a Draw".PrintToConsole();
    }

}



















Console.ReadLine();




