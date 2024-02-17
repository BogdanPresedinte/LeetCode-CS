namespace LeetCode.Test
{
    public class _0421_MaximumXOROfTwoNumbersInAnArray_Test
    {
        [Test]
        public void FindMaximumXORTest() {
            var solution = new _0421_MaximumXOROfTwoNumbersInAnArray();
            var result = solution.FindMaximumXOR(new int[] { 3, 10, 5, 25, 2, 8 });
            Assert.AreEqual(28, result);
        }
    }
}
