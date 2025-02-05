namespace LeetCode.Test
{
    public class _1072_FlipColumnsForMaximumNumberOfEqualRows_Test
    {
        [Test]
        public void MaxEqualRowsAfterFlips_1() {
            var solution = new _1072_FlipColumnsForMaximumNumberOfEqualRows();
            var result = solution.MaxEqualRowsAfterFlips(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 1 },
            });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MaxEqualRowsAfterFlips_2() {
            var solution = new _1072_FlipColumnsForMaximumNumberOfEqualRows();
            var result = solution.MaxEqualRowsAfterFlips(new int[][] {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MaxEqualRowsAfterFlips_3() {
            var solution = new _1072_FlipColumnsForMaximumNumberOfEqualRows();
            var result = solution.MaxEqualRowsAfterFlips(new int[][] {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 1 },
                new int[] { 1, 1, 0 },
            });
            Assert.AreEqual(2, result);
        }
    }
}
