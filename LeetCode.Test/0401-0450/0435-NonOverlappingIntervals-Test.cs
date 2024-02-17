namespace LeetCode.Test
{
    public class _0435_NonOverlappingIntervals_Test
    {
        [Test]
        public void EraseOverlapIntervals_1() {
            var solution = new _0435_NonOverlappingIntervals();
            var result = solution.EraseOverlapIntervals(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 },
            });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void EraseOverlapIntervals_2() {
            var solution = new _0435_NonOverlappingIntervals();
            var result = solution.EraseOverlapIntervals(new int[][] {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 },
            });
            Assert.AreEqual(2, result);
        }

        [Test]
        public void EraseOverlapIntervals_3() {
            var solution = new _0435_NonOverlappingIntervals();
            var result = solution.EraseOverlapIntervals(new int[][] {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
            });
            Assert.AreEqual(0, result);
        }
    }
}
