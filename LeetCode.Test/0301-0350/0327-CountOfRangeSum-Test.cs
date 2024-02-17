namespace LeetCode.Test
{
    public class _0327_CountOfRangeSum_Test
    {
        [Test]
        public void CountRangeSumTest() {
            var solution = new _0327_CountOfRangeSum();
            var result = solution.CountRangeSum(new int[] { -2, 5, -1 }, -2, 2);
            Assert.AreEqual(3, result);
        }
    }
}
