using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SodukuSolver.UnitTests
{
	[TestClass]
	public class SodukuSolverUnitTest
	{
		[TestMethod]
		public void IfThereIsAnInvalidSoduku_SolveSoduku_IsFalse()
		{
			//Arrange
			//notice there are two 2's directly next to each other which makes it unsolvable
			int[,] wrongSoduku = {
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
			var expected = solver.SolveSoduku(wrongSoduku);

			//Assert
			Assert.IsFalse(expected);
		}

		[TestMethod]
		public void IfThereIsAValidSoduku_SolveSoduku_IsTrue()
		{
			//Arrange
			//notice there are two 2's directly next to each other which makes it unsolvable
			int[,] soduku = {
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
			var expected = solver.SolveSoduku(soduku);

			//Assert
			Assert.IsTrue(expected);
		}

		[TestMethod]
		public void RandomSoduku_EmptySoduku_AreNotEqual()
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
			var newSudoku = new GenerateSoduku();
			var randomSoduku = newSudoku.RandomSudoku();

			//Assert
			Assert.AreNotEqual(emptySudoku, randomSoduku);
		}
	}
}
