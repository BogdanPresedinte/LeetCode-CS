namespace LeetCode.Test
{
    public class _0922_SortArrayByParityII_Test
    {
        [Test]
        public void SortArrayByParityII_1() {
            var solution = new _0922_SortArrayByParityII();
            var result = solution.SortArrayByParityII(new int[] { 4, 2, 5, 7 });
            AssertHelper.AssertArray(new int[] { 4, 5, 2, 7 }, result);
        }
    }
}
