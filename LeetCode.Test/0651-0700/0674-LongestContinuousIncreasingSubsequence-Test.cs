namespace LeetCode.Test
{
    public class _0674_LongestContinuousIncreasingSubsequence_Test
    {
        [Test]
        public void FindLengthOfLCIS_1() {
            var solution = new _0674_LongestContinuousIncreasingSubsequence();
            var result = solution.FindLengthOfLCIS(new int[] { 1, 3, 5, 4, 7 });
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindLengthOfLCIS_2() {
            var solution = new _0674_LongestContinuousIncreasingSubsequence();
            var result = solution.FindLengthOfLCIS(new int[] { 2, 2, 2, 2, 2 });
            Assert.AreEqual(1, result);
        }
    }
}
