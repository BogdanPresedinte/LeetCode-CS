namespace LeetCode.Test
{
    public class _0506_RelativeRanks_Test
    {
        [Test]
        public void FindRelativeRanks_1() {
            var solution = new _0506_RelativeRanks();
            var result = solution.FindRelativeRanks(new int[] { 5, 4, 3, 2, 1 });
            AssertHelper.AssertArray(new string[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" }, result);
        }
    }
}
