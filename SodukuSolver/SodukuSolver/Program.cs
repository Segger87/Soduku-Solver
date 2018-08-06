using System;

namespace SodukuSolver
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] sudoku = {
				{ 0,0,0,0,0,2,1,0,0 },
				{ 0,0,4,0,0,8,7,0,0 },
				{ 0,2,0,3,0,0,9,0,0 },
				{ 6,0,2,0,0,3,0,4,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,5,0,6,0,0,3,0,1 },
				{ 0,0,3,0,0,5,0,8,0 },
				{ 0,0,8,2,0,0,5,0,0 },
				{ 0,0,9,7,0,0,0,0,0 }
				};

			Console.WriteLine("This is an unsolved Sudoku:");
			var unsolvedSudoku = new SudokuSolver();
			unsolvedSudoku.PrintSudokuGrid(sudoku);

			Console.WriteLine("This is the solution:");
			var completedSudoku = new SudokuSolver();
			completedSudoku.SolveSoduku(sudoku);

			var newSudoku = new GenerateSoduku();
			var randomSoduku = newSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated unsolved Soduku");
			unsolvedSudoku.PrintSudokuGrid(randomSoduku);

			Console.WriteLine("This is the solution:");
			var completedRandomSudoku = new SudokuSolver();
			completedRandomSudoku.SolveSoduku(randomSoduku);
			Console.ReadLine();
		}
	}
}
