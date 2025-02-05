namespace LeetCode.Test
{
    public class _0912_SortAnArray_Test
    {
        [Test]
        public void SortArray_1() {
            var solution = new _0912_SortAnArray();
            var result = solution.SortArray(new int[] { 5, 2, 3, 1 });
            AssertHelper.AssertArray(new int[] { 1, 2, 3, 5 }, result);
        }

        [Test]
        public void SortArray_2() {
            var solution = new _0912_SortAnArray();
            var result = solution.SortArray(new int[] { 5, 1, 1, 2, 0, 0 });
            AssertHelper.AssertArray(new int[] { 0, 0, 1, 1, 2, 5 }, result);
        }
    }
}
