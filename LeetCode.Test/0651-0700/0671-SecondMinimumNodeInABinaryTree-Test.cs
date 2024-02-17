namespace LeetCode.Test
{
    public class _0671_SecondMinimumNodeInABinaryTree_Test
    {
        [Test]
        public void FindSecondMinimumValue_1() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 2, 5, null, null, 5, 7 });

            var solution = new _0671_SecondMinimumNodeInABinaryTree();
            var result = solution.FindSecondMinimumValue(root);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void FindSecondMinimumValue_2() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 2, 2 });

            var solution = new _0671_SecondMinimumNodeInABinaryTree();
            var result = solution.FindSecondMinimumValue(root);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void FindSecondMinimumValue_3() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 2, int.MaxValue });

            var solution = new _0671_SecondMinimumNodeInABinaryTree();
            var result = solution.FindSecondMinimumValue(root);
            Assert.AreEqual(2147483647, result);
        }
    }
}
