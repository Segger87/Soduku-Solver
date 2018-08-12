using System;

namespace SodukuSolver
{
	public class GenerateSudoku : SudokuRules
	{
		public enum Difficulty { Easy, Medium, Hard, Extreme};
		private Difficulty _difficulty;

		public int[,] PreSetSudoku ={
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

		public GenerateSudoku()
		{
			
		}

		public GenerateSudoku(Difficulty difficulty)
		{
			this._difficulty = difficulty;
		}
		
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
			var level = DifficultyLevel(_difficulty);

			for (int i = 0; i < level; i++)
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

		public int DifficultyLevel(Difficulty difficulty)
		{
			switch (difficulty)
			{
				case Difficulty.Easy:
				return 20;
				case Difficulty.Medium:
					return 12;
				case Difficulty.Hard:
					return  8;
				case Difficulty.Extreme:
					return 6;
				default:
					return 0;
			}
		}
	}
}
