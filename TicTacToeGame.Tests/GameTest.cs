using TicTacToeGame.Core;

namespace TicTacToeGame.Tests;

public class GameTest
{
    [Fact]
    public void TestMakeMove_WrongInput_ReturnFalse()
    {
        //Arrange
        int row = 7;
        int col = 8;
        var game = new Game();

        //act
        bool result = game.MakeMove(row, col, PlayerSymbol.X);

        //Assert 
        Assert.False(result);
    }
}