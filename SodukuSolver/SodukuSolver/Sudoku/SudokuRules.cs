namespace SodukuSolver
{
	public abstract class SudokuRules
	{
		private bool IsTheCurrentNumberAlreadyInTheRow(int[,] sudokuGrid, int row, int num)
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

		private bool IsTheCurrentNumberAlreadyInTheColumn(int[,] sudokuGrid, int col, int num)
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

		private bool IsTheCurrentNumberIn3x3ABox(int[,] sudokuGrid, int boxStartRow, int boxStartCol, int num)
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

		public bool IsTheMoveLegal(int[,] sudokuGrid, int row, int col, int num)
		{
			//checks if the number is not in a row, grid or 3 x 3 box
			return !IsTheCurrentNumberAlreadyInTheRow(sudokuGrid, row, num) &&
				   !IsTheCurrentNumberAlreadyInTheColumn(sudokuGrid, col, num) &&
				   !IsTheCurrentNumberIn3x3ABox(sudokuGrid, row - row % 3, col - col % 3, num);
		}
	}
}
