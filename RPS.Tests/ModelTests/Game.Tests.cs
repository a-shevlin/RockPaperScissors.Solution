using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void ReturnUserInput_ReturnUserInputToNewGame_PlayerInfo()
    {
      string player1 = "ROCK";
      string player2 = "PAPER";
      string input = player1 + ", " + player2;
      Game newGame = new Game(player1, player2);
      Assert.AreEqual(input, newGame.ReturnUserInput());
    }
    [TestMethod]
    public void ReturnWinner_CompareUserInputToReturnWinner_Winner()
    {
      string player1Input = "rock";
      string player2Input = "paper";
      Game newGame = new Game(player1Input, player2Input);
      Assert.AreEqual("Player2", newGame.ReturnWinner());
    }
    [TestMethod]
    public void ReturnWinner_CompareUserInputToReturnDraw_Draw()
    {
      string player1Input = "rock";
      string player2Input = "rock";
      Game newGame = new Game(player1Input, player2Input);
      Assert.AreEqual("It's a draw!", newGame.ReturnWinner());
    }
  } 
}