namespace LeetCode.Test
{
    public class _1464_MaximumProductOfTwoElementsInAnArray_Test
    {
        [Test]
        public void MaxProduct_1() {
            var solution = new _1464_MaximumProductOfTwoElementsInAnArray();
            var result = solution.MaxProduct(new int[] { 3, 4, 5, 2 });
            Assert.AreEqual(12, result);
        }

        [Test]
        public void MaxProduct_2() {
            var solution = new _1464_MaximumProductOfTwoElementsInAnArray();
            var result = solution.MaxProduct(new int[] { 1, 5, 4, 5 });
            Assert.AreEqual(16, result);
        }

        [Test]
        public void MaxProduct_3() {
            var solution = new _1464_MaximumProductOfTwoElementsInAnArray();
            var result = solution.MaxProduct(new int[] { 3, 7 });
            Assert.AreEqual(12, result);
        }
    }
}
