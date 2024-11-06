namespace TicTacToeGame.Core;

public class Game
{
    private int num = 1;
    private string[,] board;
    private int size = 3;
    private Random random = new Random();

    public Game()
    {
        board = new string[size, size];
    }

    //Render board to console
    public void RenderBoard()
    {
        Console.WriteLine("┌───┬───┬───┐");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"|");
            for (int j = 0; j < size; j++)
            {
                SetCellColor(board[i, j]);
                Console.Write($" {board[i, j]} ");
                Console.ResetColor();
                Console.Write($"|");
            }

            Console.WriteLine();
            if (i < size - 1)
            {
                Console.WriteLine("├───┼───┼───┤");
            }
        }
        Console.WriteLine("└───┴───┴───┘");
    }

    //Adds numbers to the cell for UI
    public void CellNumber()
    {
        //Implementing reset by assigning all array cells with empty strings
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                board[i, j] = num.ToString();
                num++;
            }
        }
    }

    //User makes a move on the board
    public bool UserMakeMove(int row, int col, PlayerSymbol symbol)
    {
        //Checks if targeted cell is empty and within row and col range to be able to place the player's symbol
        if (row >= 0 && row < size && col >= 0 && col < size && board[row, col] != PlayerSymbol.X.ToString() && board[row, col] != PlayerSymbol.O.ToString())
        {
            board[row, col] = symbol.ToString();
            return true;
        }
        Console.WriteLine("Invalid move. Try again.");
        return false;
    }

    //Computer makes a random move on the board
    public void ComputerMove(PlayerSymbol symbol)
    {
        int row, col;
        do
        {
            row = random.Next(0, size);
            col = random.Next(0, size);

        } while (board[row, col] == PlayerSymbol.X.ToString() || board[row, col] == PlayerSymbol.O.ToString());

        board[row, col] = symbol.ToString();
        Console.WriteLine($"Computer chose position: ({row},{col})\n");
    }

    //Checks for draw
    public bool IsDraw()
    {
        foreach (var cell in board)
        {
            //Checks if any cell still contains a number (indicating it's unoccupied)
            if (cell != PlayerSymbol.X.ToString() && cell != PlayerSymbol.O.ToString())
            {
                return false; //Not a draw since there’s at least one unoccupied cell
            }
        }
        num = 1;
        return true; //All cells are occupied, so it's a draw
    }

    //Checks for different winning combinations
    public bool CheckWin(PlayerSymbol symbol)
    {
        string s = symbol.ToString();

        //Checks for horizontal (row) and vertical (column) winnings combinations
        for (int i = 0; i < size; i++)
        {
            if ((board[i, 0] == s && board[i, 1] == s && board[i, 2] == s) || //Row
                (board[0, i] == s && board[1, i] == s && board[2, i] == s)) //Col
            {
                num = 1;
                return true; //Exists the method and return true if combination is found here
            }
        }

        //Checks for diagonal winning combinations
        if ((board[0, 0] == s && board[1, 1] == s && board[2, 2] == s) || //Top-Left - Bottom-Right
            (board[0, 2] == s && board[1, 1] == s && board[2, 0] == s))   //Top-Right - Bottom-Left
        {
            num = 1;
            return true; //Exists the method and return true if combination is found here
        }
        return false; //If no combination is found then return false
    }

    //Sets player symbol to green or red
    private void SetCellColor(string cell)
    {
        if (cell == PlayerSymbol.X.ToString())
            Console.ForegroundColor = ConsoleColor.Green;
        else if (cell == PlayerSymbol.O.ToString())
            Console.ForegroundColor = ConsoleColor.Red;
    }

}


