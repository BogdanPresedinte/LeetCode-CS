namespace LeetCode.Test
{
    public class _0739_DailyTemperatures_Test
    {
        [Test]
        public void DailyTemperatures_1() {
            var solution = new _0739_DailyTemperatures();
            var result = solution.DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
            AssertHelper.AssertArray(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 }, result);
        }
    }
}
