namespace LeetCode.Test
{
    public class _0370_RangeAddition_Test
    {
        [Test]
        public void GetModifiedArray_1() {
            var solution = new _0370_RangeAddition();
            var result = solution.GetModifiedArray(5, new int[][] {
                new int[] { 1, 3, 2 },
                new int[] { 2, 4, 3 },
                new int[] { 0, 2, -2 },
            });
            AssertHelper.AssertArray(new int[] { -2, 0, 3, 5, 3 }, result);
        }
    }
}
