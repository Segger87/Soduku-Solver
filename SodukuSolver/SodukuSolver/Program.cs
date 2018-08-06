using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuSolver
{
	class Program
	{
		public static Tuple<int, int> GridFull = Tuple.Create(9, 9);

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

			PrintSudokuGrid(sudoku);

			var result = SolveSoduku(sudoku);

			if (result == true)
			{
				PrintSudokuGrid(sudoku);
			}

			Console.ReadLine();
		}

		public static void PrintSudokuGrid(int[,] sudokuGrid)
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

		public static bool IsTheCurrentNumberAlreadyInTheRow(int[,] sudokuGrid, int row, int num)
		{
			for (int i = 0; i < 9; i++)
			{
				if (row < 9 && sudokuGrid[row, i] == num)
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsTheCurrentNumberAlreadyInTheColumn(int[,] sudokuGrid, int col, int num)
		{
			for (int i = 0; i < 9; i++)
			{
				if (col < 9 && sudokuGrid[i, col] == num)
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsTheCurrentNumberInABox(int[,] sudokuGrid, int boxStartRow, int boxStartCol, int num)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (boxStartRow < 9 && boxStartCol < 9 && sudokuGrid[i + boxStartRow, j + boxStartCol] == num)
					{
						return true;
					}
				}
			}
			return false;
		}

		public static bool IsTheMoveLegal(int[,] sudokuGrid, int row, int col, int num)
		{
			return !IsTheCurrentNumberAlreadyInTheRow(sudokuGrid, row, num) &&
				   !IsTheCurrentNumberAlreadyInTheColumn(sudokuGrid, col, num) &&
				   !IsTheCurrentNumberInABox(sudokuGrid, row - row % 3, col - col % 3, num);
		}

		public static Tuple<int, int> GetUnassignedLocations(int[,] sudokuGrid)
		{
			
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

			return GridFull;
		}

		public static bool SolveSoduku(int[,] sudokuGrid)
		{

			if (GridFull == GetUnassignedLocations(sudokuGrid))
			{
				return true;
			}

			Tuple<int, int> rowAndCol = GetUnassignedLocations(sudokuGrid);
			int row = rowAndCol.Item1;
			int col = rowAndCol.Item2;

			for (int num = 1; num <= 9; num++)
			{
				if (IsTheMoveLegal(sudokuGrid, row, col, num))
				{
					sudokuGrid[row, col] = num;
					if (SolveSoduku(sudokuGrid))
					{
						return true;
					}
					sudokuGrid[row, col] = 0;
				}
			}
			return false;
		}
	}
}
