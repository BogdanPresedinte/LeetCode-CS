namespace LeetCode.Test
{
    public class _0636_ExclusiveTimeOfFunctions_Test
    {
        [Test]
        public void ExclusiveTime_1() {
            var solution = new _0636_ExclusiveTimeOfFunctions();
            var result = solution.ExclusiveTime(2, new string[] { "0:start:0", "1:start:2", "1:end:5", "0:end:6" });
            AssertHelper.AssertArray(new int[] { 3, 4 }, result);
        }
    }
}
