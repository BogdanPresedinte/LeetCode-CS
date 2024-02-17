namespace LeetCode.Test
{
    public class _0628_MaximumProductOfThreeNumbers_Test
    {
        [Test]
        public void MaximumProduct_1() {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, 3 });
            Assert.AreEqual(6, result);
        }

        [Test]
        public void MaximumProduct_2() {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(24, result);
        }

        [Test]
        public void MaximumProduct_3() {
            var solution = new _0628_MaximumProductOfThreeNumbers();
            var result = solution.MaximumProduct(new int[] { 1, 2, -3, -4 });
            Assert.AreEqual(24, result);
        }
    }
}
