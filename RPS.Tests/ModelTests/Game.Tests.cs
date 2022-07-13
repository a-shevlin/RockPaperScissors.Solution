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
      string player1 = "rock";
      string player2 = "paper";
      string input = player1 + ", " + player2;
      Game newGame = new Game(player1, player2);
      Assert.AreEqual(input, newGame.ReturnUserInput());
    }
  } 
}