namespace LeetCode.Test
{
    public class _0503_NextGreaterElementII_Test
    {
        [Test]
        public void NextGreaterElements_1() {
            var solution = new _0503_NextGreaterElementII();
            var result = solution.NextGreaterElements(new int[] { 1, 2, 1 });
            AssertHelper.AssertArray(new int[] { 2, -1, 2 }, result);
        }
    }
}
