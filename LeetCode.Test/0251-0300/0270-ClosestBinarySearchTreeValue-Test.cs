namespace LeetCode.Test
{
    public class _0270_ClosestBinarySearchTreeValue_Test
    {
        [Test]
        public void ClosestValue_1() {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 5, 1, 3 });

            var solution = new _0270_ClosestBinarySearchTreeValue();
            var result = solution.ClosestValue(root, 3.714286);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ClosestValue_2() {
            var root = TestHelper.GenerateTree(new int?[] { 2147483647 });

            var solution = new _0270_ClosestBinarySearchTreeValue();
            var result = solution.ClosestValue(root, 0.0);
            Assert.AreEqual(2147483647, result);
        }
    }
}
