namespace LeetCode.Test
{
    public class _1099_TwoSumLessThanK_Test
    {
        [Test]
        public void TwoSumLessThanK_1() {
            var solution = new _1099_TwoSumLessThanK();
            var result = solution.TwoSumLessThanK(new int[] { 34, 23, 1, 24, 75, 33, 54, 8 }, 60);
            Assert.AreEqual(58, result);
        }

        [Test]
        public void TwoSumLessThanK_2() {
            var solution = new _1099_TwoSumLessThanK();
            var result = solution.TwoSumLessThanK(new int[] { 10, 20, 30 }, 15);
            Assert.AreEqual(-1, result);
        }
    }
}
