namespace LeetCode.Test
{
    public class _1287_ElementAppearingMoreThan25InSortedArray_Test
    {
        [Test]
        public void FindSpecialInteger_1() {
            var solution = new _1287_ElementAppearingMoreThan25InSortedArray();
            var result = solution.FindSpecialInteger(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 });
            Assert.AreEqual(6, result);
        }
    }
}
