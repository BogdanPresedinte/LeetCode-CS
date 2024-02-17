namespace LeetCode.Test
{
    public class _104_MaximumDepthOfBinaryTree_Test
    {
        [Test]
        public void MaxDepthTest() {
            var solution = new _104_MaximumDepthOfBinaryTree();
            var result = solution.MaxDepth(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            Assert.AreEqual(3, result);
        }

        [Test]
        public void MaxDepthTest_Null() {
            var solution = new _104_MaximumDepthOfBinaryTree();
            var result = solution.MaxDepth(null);
            Assert.AreEqual(0, result);
        }
    }
}
