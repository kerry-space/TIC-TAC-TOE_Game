using TicTacToeGame.Core;

public class Program
{
    public static int col = 0;
    public static int row = 0;

    public static void Main()
    {
        Game game = new Game();
        PlayerSymbol player = PlayerSymbol.X;
        PlayerSymbol computer = PlayerSymbol.O;
        bool endGame = true;

        Console.Clear();
        Console.WriteLine("Welcome to Tic Tac Toe!");

        while (endGame)
        {
            Console.WriteLine();
            game.CellNumber();
            game.RenderBoard();

            while (true)
            {
                // Player's turn
                Console.Write($"\nPlayer {player}, make your move (1-9): ");
                int userMove = GetInputFromUser();
                Console.WriteLine();

                GetBoardPosition(userMove);

                if (game.UserMakeMove(row, col, player))
                {
                    game.RenderBoard();

                    if (game.CheckWin(player))
                    {
                        Console.WriteLine($"Congratulations! {player} wins!");
                        break;
                    }

                    if (game.IsDraw())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    // Switch to computer's turn
                    Console.WriteLine("\nComputer's turn...");
                    Thread.Sleep(1000);
                    game.ComputerMove(computer);
                    game.RenderBoard();

                    if (game.CheckWin(computer))
                    {
                        Console.WriteLine("🏆Computer wins! 🎉");
                        break;
                    }

                    if (game.IsDraw())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                }
            }

            Console.Write("Do you want to play again? (y/n): ");
            char playAgain = Console.ReadKey().KeyChar;
            if (playAgain == 'y' || playAgain == 'Y')
            {
                Console.Clear();
                endGame = true;
            }
            else
            {
                endGame = false;
            }
        }
    }

    //Methods
    public static void GetBoardPosition(int userMove)
    {
        switch (userMove)
        {
            case 1:
                row = 0;
                col = 0;
                break;
            case 2:
                row = 0;
                col = 1;
                break;
            case 3:
                row = 0;
                col = 2;
                break;
            case 4:
                row = 1;
                col = 0;
                break;
            case 5:
                row = 1;
                col = 1;
                break;
            case 6:
                row = 1;
                col = 2;
                break;
            case 7:
                row = 2;
                col = 0;
                break;
            case 8:
                row = 2;
                col = 1;
                break;
            case 9:
                row = 2;
                col = 2;
                break;
        }
    }

    public static int GetInputFromUser()
    {
        string userInput = Console.ReadLine();
        int userMove = 0;
        while (true)
        {
            if (int.TryParse(userInput, out userMove))
            {
                return userMove;
            }
            Console.Write("Please enter correct move!: ");
        }
    }



}