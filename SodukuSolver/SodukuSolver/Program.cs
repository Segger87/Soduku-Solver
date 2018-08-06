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
			var solve = new SudokuSolver();
			solve.PrintSudokuGrid(generateSudoku.PreSetSudoku);

			Console.WriteLine("This is the solution:");
			solve.SolveSudoku(generateSudoku.PreSetSudoku);

			var newSudoku = new GenerateSudoku(GenerateSudoku.Difficulty.Easy);
			var randomSoduku = newSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated Easy unsolved Soduku:");
			solve.PrintSudokuGrid(randomSoduku);

			Console.WriteLine("This is the solution:");
			solve.SolveSudoku(randomSoduku);

			var hardSudoku = new GenerateSudoku(GenerateSudoku.Difficulty.Hard);
			var randomHardsudoku = hardSudoku.RandomSudoku();

			Console.WriteLine("This is a randomly generated Hard unsolved Soduku:");
			solve.PrintSudokuGrid(randomHardsudoku);

			Console.WriteLine("This is the solution:");
			solve.SolveSudoku(randomHardsudoku);

			Console.ReadLine();
		}
	}
}
