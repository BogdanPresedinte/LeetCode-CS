namespace LeetCode.Test
{
    public class _1508_RangeSumOfSortedSubarraySums_Test
    {
        [Test]
        public void RangeSum_1() {
            var solution = new _1508_RangeSumOfSortedSubarraySums();
            var result = solution.RangeSum(new int[] { 1, 2, 3, 4 }, 4, 1, 5);
            Assert.AreEqual(13, result);
        }

        [Test]
        public void RangeSum_2() {
            var solution = new _1508_RangeSumOfSortedSubarraySums();
            var result = solution.RangeSum(new int[] { 1, 2, 3, 4 }, 4, 3, 4);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void RangeSum_3() {
            var solution = new _1508_RangeSumOfSortedSubarraySums();
            var result = solution.RangeSum(new int[] { 1, 2, 3, 4 }, 4, 1, 10);
            Assert.AreEqual(50, result);
        }
    }
}
