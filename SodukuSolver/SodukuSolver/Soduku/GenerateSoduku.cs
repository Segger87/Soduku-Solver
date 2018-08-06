using System;

namespace SodukuSolver
{
	public class GenerateSoduku : CheckColRowAndBoxForLegalMoves
	{
		public int[,] RandomSudoku()
		{
			int[,] sudoku = {
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,0,0,0,0,0,0,0,0 }
				};

			var random = new Random();
			for (int i = 0; i < 10; i++)
			{	
				var row = random.Next(0, 8);
				var col = random.Next(0, 8);
				var number = random.Next(1, 9);

				if(IsTheMoveLegal(sudoku, row, col, number))
				{
					sudoku[row, col] = number;
				}
			}

			return sudoku;
		}
	}
}
