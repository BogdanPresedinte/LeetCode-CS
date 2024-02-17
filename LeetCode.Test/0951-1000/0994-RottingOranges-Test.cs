namespace LeetCode.Test
{
    public class _0994_RottingOranges_Test
    {
        [Test]
        public void OrangesRotting_1() {
            var solution = new _0994_RottingOranges();
            var result = solution.OrangesRotting(new int[][] {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 },
            });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void OrangesRotting_2() {
            var solution = new _0994_RottingOranges();
            var result = solution.OrangesRotting(new int[][] {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 },
            });
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void OrangesRotting_3() {
            var solution = new _0994_RottingOranges();
            var result = solution.OrangesRotting(new int[][] {
                new int[] { 0, 2 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
