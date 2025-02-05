namespace LeetCode.Test
{
    public class _0908_SmallestRangeI_Test
    {
        [Test]
        public void SmallestRangeI_1() {
            var solution = new _0908_SmallestRangeI();
            var result = solution.SmallestRangeI(new int[] { 1 }, 0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SmallestRangeI_2() {
            var solution = new _0908_SmallestRangeI();
            var result = solution.SmallestRangeI(new int[] { 0, 10 }, 2);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void SmallestRangeI_3() {
            var solution = new _0908_SmallestRangeI();
            var result = solution.SmallestRangeI(new int[] { 1, 3, 6 }, 3);
            Assert.AreEqual(0, result);
        }
    }
}
