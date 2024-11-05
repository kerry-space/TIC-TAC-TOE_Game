# Create the solution
dotnet new sln -n TicTacToeGameSolution


# Create the core library project (for game logic)
dotnet new classlib -n TicTacToeGame.Core
# Verkare inte behövas --> dotnet add TicTacToeGame.Core package System.Collections.Immutable


# Create the console application project
dotnet new console -n TicTacToeGame.ConsoleApp


# Create the test project using xUnit
dotnet new xunit -n TicTacToeGame.Tests
dotnet add TicTacToeGame.Tests package Shouldly


# Add project references
dotnet add TicTacToeGame.ConsoleApp reference TicTacToeGame.Core
dotnet add TicTacToeGame.Tests reference TicTacToeGame.Core


# Add the projects to the solution
dotnet sln TicTacToeGameSolution.sln add TicTacToeGame.Core/TicTacToeGame.Core.csproj
dotnet sln TicTacToeGameSolution.sln add TicTacToeGame.ConsoleApp/TicTacToeGame.ConsoleApp.csproj
dotnet sln TicTacToeGameSolution.sln add TicTacToeGame.Tests/TicTacToeGame.Tests.csproj


