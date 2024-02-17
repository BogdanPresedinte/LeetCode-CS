namespace LeetCode.Test
{
    public class _0645_SetMismatch_Test
    {
        [Test]
        public void FindErrorNums_1() {
            var solution = new _0645_SetMismatch();
            var result = solution.FindErrorNums(new int[] { 1, 2, 2, 4 });
            AssertHelper.AssertArray(new int[] { 2, 3 }, result);
        }
    }
}
