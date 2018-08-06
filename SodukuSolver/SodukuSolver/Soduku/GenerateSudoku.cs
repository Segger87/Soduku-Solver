using System;

namespace SodukuSolver
{
	public class GenerateSudoku : SudokuRules
	{
		public int[,] PreSetSudoku =
		{
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
