using System;
using RPS.Models;

namespace RPS.Program
{
  public class Program
  {
    public static void Main()
    {
      bool playAgain = true;
      string player1;
      string player2;

      while(playAgain)
      {
        Console.Clear();
        Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS");
        Console.WriteLine("Player1 Select ROCK PAPER or SCISSORS");
        player1 = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Player2 Select ROCK PAPER or SCISSORS");
        player2 = Console.ReadLine();
        Console.Clear();
        Game newGame = new Game(player1, player2);
        string output1 = newGame.ReturnUserInputOne();
        string output2 = newGame.ReturnUserInputTwo();
        string result = newGame.ReturnWinner();
        Console.WriteLine(output1);
        Console.WriteLine(output2);
        Console.WriteLine(result);

      }
    }
  }
}