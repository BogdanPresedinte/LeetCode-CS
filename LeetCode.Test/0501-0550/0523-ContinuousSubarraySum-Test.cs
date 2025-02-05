namespace LeetCode.Test
{
    public class _0523_ContinuousSubarraySum_Test
    {
        [Test]
        public void CheckSubarraySum_1() {
            var solution = new _0523_ContinuousSubarraySum();
            var result = solution.CheckSubarraySum(new int[] { 23, 2, 4, 6, 7 }, 6);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckSubarraySum_2() {
            var solution = new _0523_ContinuousSubarraySum();
            var result = solution.CheckSubarraySum(new int[] { 23, 2, 6, 4, 7 }, 6);
            Assert.IsTrue(result);
        }
    }
}
