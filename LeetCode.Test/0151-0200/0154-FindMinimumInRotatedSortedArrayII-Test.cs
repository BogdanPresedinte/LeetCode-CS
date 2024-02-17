namespace LeetCode.Test
{
    public class _0154_FindMinimumInRotatedSortedArrayII_Test
    {
        [Test]
        public void FindMin_1() {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 1, 3, 5 });
            Assert.AreEqual(1, result);
        }

        [Test]
        public void FindMin_2() {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 2, 2, 2, 0, 1 });
            Assert.AreEqual(0, result);
        }

        [Test]
        public void FindMin_3() {
            var solution = new _0154_FindMinimumInRotatedSortedArrayII();
            var result = solution.FindMin(new int[] { 2, 2, 2, 0, 2, 2, 2, 2, 2 });
            Assert.AreEqual(0, result);
        }
    }
}
