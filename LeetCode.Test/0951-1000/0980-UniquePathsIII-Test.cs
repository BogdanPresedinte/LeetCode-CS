namespace LeetCode.Test
{
    public class _0980_UniquePathsIII_Test
    {
        [Test]
        public void UniquePathsIII_1() {
            var solution = new _0980_UniquePathsIII();
            var result = solution.UniquePathsIII(new int[][] {
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 2, -1 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void UniquePathsIII_2() {
            var solution = new _0980_UniquePathsIII();
            var result = solution.UniquePathsIII(new int[][] {
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 2 },
            });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void UniquePathsIII_3() {
            var solution = new _0980_UniquePathsIII();
            var result = solution.UniquePathsIII(new int[][] {
                new int[] { 0, 1 },
                new int[] { 2, 0 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
