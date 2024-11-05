using System.Security.Cryptography.X509Certificates;

namespace TicTacToeGame.Core;

public class Game
{
    // Fields or properties
    private string[,] board;
    private int size = 3;

    // Constructor
    public Game()
    {
        board = new string[size, size];
        ResetGame(); 
    }

    // Methods

    // Render the game board to the console
    public void RenderBoard()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Make a move on the board
    public bool MakeMove(int row, int col, string symbol)
    {
     
        return true;
    }

    // Check if a player has won
    public bool CheckWin(string symbol)
    {
        // Horizontal, vertical, and diagonal checks
       
        return false;
    }

    // Reset the game board
    public void ResetGame()
    {
       
    }
}


