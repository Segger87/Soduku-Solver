using System;

namespace SodukuSolver
{
	class Program
	{
		static void Main(string[] args)
		{
			new Program().Execute();
		}

		private void Execute()
		{
			Console.WriteLine("This is an unsolved Sudoku:");
			var generateSudoku = new GenerateSudoku();
			var unsolvedSudoku = new SudokuSolver();
			unsolvedSudoku.PrintSudokuGrid(generateSudoku.PreSetSudoku);

			Console.WriteLine("This is the solution:");
			var completedSudoku = new SudokuSolver();
			completedSudoku.SolveSudoku(generateSudoku.PreSetSudoku);

			var newSudoku = new GenerateSudoku();
			var randomSoduku = newSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated unsolved Soduku:");
			unsolvedSudoku.PrintSudokuGrid(randomSoduku);

			Console.WriteLine("This is the solution:");
			var completedRandomSudoku = new SudokuSolver();
			completedRandomSudoku.SolveSudoku(randomSoduku);
			Console.ReadLine();
		}
	}
}
