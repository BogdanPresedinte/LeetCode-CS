namespace LeetCode.Test
{
    public class _0969_PancakeSorting_Test
    {
        [Test]
        public void PancakeSort_1() {
            var solution = new _0969_PancakeSorting();
            var result = solution.PancakeSort(new int[] { 3, 2, 4, 1 });
            AssertHelper.AssertList(new int[] { 3, 4, 2, 3, 1, 2 }, result);
        }

        [Test]
        public void PancakeSort_2() {
            var solution = new _0969_PancakeSorting();
            var result = solution.PancakeSort(new int[] { 1, 2, 3 });
            Assert.AreEqual(0, result.Count);
        }
    }
}
