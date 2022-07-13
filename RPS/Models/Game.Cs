//Recreate game of rock, paper, scissors

//Requirements___
//2 inputs Player 1 && Player 2 -> Choose at the same time.
//rock beats scissors, scissors beats paper, and paper beats rock
//If both inputs are equal then game ends as draw.

// rock === 1; paper === 2; scissors === 3 maybe

//Further Exploration___
//Have computer select a play instead of a player
//Expand rules to allow 3 players

//Code

namespace RPS.Models
{
  public class Game
  {
    public string Player1 = "Player1"; //can change to name of player
    private string OneInput{ get; set; }
    public string Player2 = "Player2"; 
    private string TwoInput{ get; set; }
    public string Result{ get; set; }

    public Game(string player1, string player2)
    {
      OneInput = player1.ToUpper();
      TwoInput = player2.ToUpper();
    }

    public string ReturnUserInput()
    {
      string newInput = OneInput + ", " + TwoInput;
      return newInput;
    }

    public string ReturnWinner()
    {
      switch(OneInput) {
        case "ROCK": //1
          if(TwoInput == "ROCK") //1 == 1
          {
            Result = "It's a draw!";
            return Result;
          }
          else if(TwoInput == "PAPER") //1 beats 2
          {
            Result = Player2;
            return Result;
          }
          else //3
          {
            Result = Player1;
            return Result;
          }
        case "PAPER": //2
          if(TwoInput == "ROCK") //1
          {
            Result = Player1;
            return Result;
          }
          else if(TwoInput == "PAPER") //2
          {
            Result = "It's a draw!";
            return Result;
          }
          else //3
          {
            Result = Player2;
            return Result;
          }
        case "SCISSORS": //3
          if(TwoInput == "ROCK") //1
          {
            Result = Player2;
            return Result;
          }
          else if(TwoInput == "PAPER") //2
          {
            Result = Player1;
            return Result;
          }
          else
          {
            Result = "It's a draw!"; //3
            return Result;
          }
      }
      return Result;
    }
  }
}