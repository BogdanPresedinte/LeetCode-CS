namespace LeetCode.Test
{
    public class _1277_CountSquareSubmatricesWithAllOnes_Test
    {
        [Test]
        public void CountSquares_1() {
            var solution = new _1277_CountSquareSubmatricesWithAllOnes();
            var result = solution.CountSquares(new int[][] {
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 1, 1, 1 },
            });
            Assert.AreEqual(15, result);
        }

        [Test]
        public void CountSquares_2() {
            var solution = new _1277_CountSquareSubmatricesWithAllOnes();
            var result = solution.CountSquares(new int[][] {
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 },
            });
            Assert.AreEqual(7, result);
        }
    }
}
