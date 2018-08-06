using System;

namespace SodukuSolver
{
	public class SudokuSolver : CheckColRowAndBoxForLegalMoves
	{
		public static Tuple<int, int> GridFull = Tuple.Create(9, 9);

		public void PrintSudokuGrid(int[,] sudokuGrid)
		{
			Console.WriteLine("__________________");
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if (sudokuGrid[i, j] == 0)
					{
						Console.Write("_");
						Console.Write("|");
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(sudokuGrid[i, j]);
						Console.ResetColor();
						Console.Write("|");
					}
				}
				Console.WriteLine("");
			}
			Console.WriteLine();
		}

		private Tuple<int, int> GetEmptyGridLocations(int[,] sudokuGrid)
		{
			//returns a tuple of row and col coordinates that are empty on the sudoku
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if (sudokuGrid[i, j] == 0)
					{
						return Tuple.Create(i, j);
					}
				}
			}
			//if no more empty spaces the grid is full
			return GridFull;
		}

		public bool SolveSoduku(int[,] sudokuGrid)
		{
			if (GridFull == GetEmptyGridLocations(sudokuGrid))
			{
				PrintSudokuGrid(sudokuGrid);
				return true;
			}

			//get unassigned grid locations
			Tuple<int, int> rowAndCol = GetEmptyGridLocations(sudokuGrid);
			int row = rowAndCol.Item1;
			int col = rowAndCol.Item2;

			for (int num = 1; num <= 9; num++)
			{
				if (IsTheMoveLegal(sudokuGrid, row, col, num))
				{
					//makes a tentative assignment
					sudokuGrid[row, col] = num;

					//recursively call the function until all number placements are valid
					if (SolveSoduku(sudokuGrid))
					{
						return true;
					}

					//as it is unable to validly go through all the recursions there must be an invalid number, 
					//go back and try a different number for this particular unassigned location
					sudokuGrid[row, col] = 0;
				}
			}
			return false;
		}
	}
}
