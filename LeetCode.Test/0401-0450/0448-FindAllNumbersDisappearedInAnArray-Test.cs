namespace LeetCode.Test
{
    public class _0448_FindAllNumbersDisappearedInAnArray_Test
    {
        [Test]
        public void FindDisappearedNumbers_1() {
            var solution = new _0448_FindAllNumbersDisappearedInAnArray();
            var result = solution.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            AssertHelper.AssertList(new int[] { 5, 6 }, result);
        }
    }
}
