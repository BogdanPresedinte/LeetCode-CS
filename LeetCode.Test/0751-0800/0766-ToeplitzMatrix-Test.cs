namespace LeetCode.Test
{
    public class _0766_ToeplitzMatrix_Test
    {
        [Test]
        public void IsToeplitzMatrix_1() {
            var solution = new _0766_ToeplitzMatrix();
            var result = solution.IsToeplitzMatrix(new int[][] {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 1, 2, 3 },
                new int[] { 9, 5, 1, 2 },
            });
            Assert.IsTrue(result);
        }

        [Test]
        public void IsToeplitzMatrix_2() {
            var solution = new _0766_ToeplitzMatrix();
            var result = solution.IsToeplitzMatrix(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 2 }
            });
            Assert.IsFalse(result);
        }
    }
}
