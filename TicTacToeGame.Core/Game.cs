﻿using System.Security.Cryptography.X509Certificates;

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
    public bool MakeMove(int row, int col, PlayerSymbol symbol)
    {
        //Checks if targeted cell is empty and within row and col range to be able to place the player's symbol
        if (row >= 0 && row < size && col >= 0 && col < size && board[row, col] == " ")
        {
            board[row, col] = symbol.ToString();
            return true;
        }
        Console.WriteLine("Invalid move. Try again.");
        return false;
    }

    // Check if a player has won
    public bool CheckWin(PlayerSymbol symbol)
    {
        string s = symbol.ToString();

        //Checks for horizontal (row) and vertical (column) winnings combinations
        for (int i = 0; i < size; i++)
        {
            if ((board[i, 0] == s && board[i, 1] == s && board[i, 2] == s) || //Row
                (board[0, i] == s && board[1, i] == s && board[2, i] == s)) //Col
            {
                return true; //Exists the method and return true if combination is found here
            }
        }

        //Checks for diagonal winning combinations
        if ((board[0, 0] == s && board[1, 1] == s && board[2, 2] == s) || //Top-Left - Bottom-Right
            (board[0, 2] == s && board[1, 1] == s && board[2, 0] == s))   //Top-Right - Bottom-Left
        {
            return true;
        }

        return false; //If no combination is found then return false
    }

    // Reset the game board
    public void ResetGame()
    {
        //Implementing reset by assigning all array cells with empty strings
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                board[i, j] = " ";
            }
        }
    }
}


