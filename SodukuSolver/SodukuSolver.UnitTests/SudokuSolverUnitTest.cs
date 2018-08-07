using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SodukuSolver.UnitTests
{
	[TestClass]
	public class SudokuSolverUnitTest
	{
		[TestMethod]
		public void IfThereIsAnInvalidSudoku_SolveSudoku_IsFalse()
		{
			//Arrange
			//notice there are two 2's directly next to each other which makes it unsolvable
			int[,] wrongSudoku = {
				{ 0,0,0,0,0,2,2,0,0 },
				{ 0,0,4,0,0,8,7,0,0 },
				{ 0,2,0,3,0,0,9,0,0 },
				{ 6,0,2,0,0,3,0,4,0 },
				{ 0,0,0,0,0,0,0,0,0 },
				{ 0,5,0,6,0,0,3,0,1 },
				{ 0,0,3,0,0,5,0,8,0 },
				{ 0,0,8,2,0,0,5,0,0 },
				{ 0,0,9,7,0,0,0,0,0 }
				};

			//Act
			var solver = new SudokuSolver();
			var expected = solver.SolveSudoku(wrongSudoku);

			//Assert
			Assert.IsFalse(expected);
		}

		[TestMethod]
		public void IfThereIsAValidSudoku_SolveSudoku_IsTrue()
		{
			//Arrange
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

			//Act
			var solver = new SudokuSolver();
			var expected = solver.SolveSudoku(sudoku);

			//Assert
			Assert.IsTrue(expected);
		}

		[TestMethod]
		public void RandomSoduku_EmptySudoku_AreNotEqual()
		{
			//Arrange
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

			//Act
			var newSudoku = new GenerateSudoku();
			var randomSoduku = newSudoku.RandomSudoku();

			//Assert
			Assert.AreNotEqual(emptySudoku, randomSoduku);
		}

		[TestMethod]
		public void IfDifficultyLevelIsEasy_Sudokuhas20PresetNumbers_IsTrue()
		{
			//Arrange
			var generateSudoku = new GenerateSudoku();
			const int expected = 20;

			//Act
			var actual = generateSudoku.DifficultyLevel(GenerateSudoku.Difficulty.Easy);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void IfDifficultyLevelIsMedium_Sudokuhas12PresetNumbers_IsTrue()
		{
			//Arrange
			var generateSudoku = new GenerateSudoku();
			const int expected = 12;

			//Act
			var actual = generateSudoku.DifficultyLevel(GenerateSudoku.Difficulty.Medium);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void IfDifficultyLevelIsHard_Sudokuhas8PresetNumbers_IsTrue()
		{
			//Arrange
			var generateSudoku = new GenerateSudoku();
			const int expected = 8;

			//Act
			var actual = generateSudoku.DifficultyLevel(GenerateSudoku.Difficulty.Hard);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void IfDifficultyLevelIsExtreme_Sudokuhas6PresetNumbers_IsTrue()
		{
			//Arrange
			var generateSudoku = new GenerateSudoku();
			const int expected = 6;

			//Act
			var actual = generateSudoku.DifficultyLevel(GenerateSudoku.Difficulty.Extreme);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
