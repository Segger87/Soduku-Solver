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
			Console.WriteLine("This is the pre-set unsolved Sudoku:");
			var generateSudoku = new GenerateSudoku();
			var unsolvedSudoku = new SudokuSolver();
			unsolvedSudoku.PrintSudokuGrid(generateSudoku.PreSetSudoku);

			Console.WriteLine("This is the solution:");
			var completedSudoku = new SudokuSolver();
			completedSudoku.SolveSudoku(generateSudoku.PreSetSudoku);

			var newSudoku = new GenerateSudoku(GenerateSudoku.Difficulty.Easy);
			var randomSoduku = newSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated Easy unsolved Soduku:");
			unsolvedSudoku.PrintSudokuGrid(randomSoduku);

			Console.WriteLine("This is the solution:");
			var completedRandomSudoku = new SudokuSolver();
			completedRandomSudoku.SolveSudoku(randomSoduku);

			var hardSudoku = new GenerateSudoku(GenerateSudoku.Difficulty.Hard);
			var randomHardsudoku = hardSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated Hard unsolved Soduku:");
			unsolvedSudoku.PrintSudokuGrid(randomHardsudoku);

			Console.WriteLine("This is the solution:");
			var completedHardSudoku = new SudokuSolver();
			completedHardSudoku.SolveSudoku(randomHardsudoku);

			Console.ReadLine();
		}
	}
}
