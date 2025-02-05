namespace LeetCode.Test
{
    public class _0300_LongestIncreasingSubsequence_Test
    {
        [Test]
        public void LengthOfLIS_1() {
            var solution = new _0300_LongestIncreasingSubsequence();
            var result = solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            Assert.AreEqual(4, result);
        }

        [Test]
        public void LengthOfLIS_2() {
            var solution = new _0300_LongestIncreasingSubsequence();
            var result = solution.LengthOfLIS(new int[] { 10, 11, 2, 12, 13, 14 });
            Assert.AreEqual(5, result);
        }
    }
}
