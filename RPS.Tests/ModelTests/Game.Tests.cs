using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void ReturnUserInputOne_ReturnUserInputToNewGame_ROCK()
    {
      string player1 = "ROCK";
      string player2 = "PAPER";
      string output = "Player1 selected ROCK";
      Game newGame = new Game(player1, player2);
      Assert.AreEqual(output, newGame.ReturnUserInputOne());
    }
    [TestMethod]
    public void ReturnUserInputTwo_CheckUserInputIfValid_NotValid()
    {
      string player1Input = "gun";
      string player2Input = "rock";
      string error = "NOT A VALID INPUT";
      Game newGame = new Game(player1Input, player2Input);
      Assert.AreEqual(error, newGame.ReturnUserInputOne());
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