using TicTacToeGame.Core;

namespace TicTacToeGame.Tests;

public class GameTest
{
    [Fact]
    public void TestUserMakeMove_InvalidMove_ReturnFalse()
    {
        //Arrange
        int row = 7;
        int col = 8;
        var game = new Game();

        //Act
        bool result = game.UserMakeMove(row, col, PlayerSymbol.X);

        //Assert 
        Assert.False(result);
    }
}