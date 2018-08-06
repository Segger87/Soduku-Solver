using System;

namespace SodukuSolver
{
	public class GenerateSoduku : SudokuRules
	{
		public int[,] RandomSudoku()
		{
			int[,] emptySudoku = {
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

				if(IsTheMoveLegal(emptySudoku, row, col, number))
				{
					emptySudoku[row, col] = number;
				}
			}

			return emptySudoku;
		}
	}
}
