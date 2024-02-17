namespace LeetCode.Test
{
    public class _1161_MaximumLevelSumOfABinaryTree_Test
    {
        [Test]
        public void MaxLevelSum_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 7, 0, 7, -8, null, null });

            var solution = new _1161_MaximumLevelSumOfABinaryTree();
            var result = solution.MaxLevelSum(root);
            Assert.AreEqual(2, result);
        }
    }
}
