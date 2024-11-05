namespace TicTacToeGame.Core;

public enum PlayerSymbol
{
    X, O
}

public class Player
{
    public PlayerSymbol Symbol { get; set; }

    public Player(PlayerSymbol symbol)
    {
        Symbol = symbol;
    }
}
