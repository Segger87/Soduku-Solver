using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

			new Program().PrintSudokuGrid(sudoku);
			Console.ReadLine();
		}

		public void PrintSudokuGrid(int[,] sudokuGrid)
		{
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
						Console.Write(sudokuGrid[i,j]);
						Console.Write("|");
						Console.ResetColor();				
					}
				}
				Console.WriteLine("");
			}
		}
	}
}
