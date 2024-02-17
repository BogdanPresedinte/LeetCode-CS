namespace LeetCode.Test
{
    public class _0965_UnivaluedBinaryTree_Test
    {
        [Test]
        public void IsUnivalTree_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 1, 1, 1, 1, null, 1 });

            var solution = new _0965_UnivaluedBinaryTree();
            var result = solution.IsUnivalTree(root);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsUnivalTree_2() {
            var root = TestHelper.GenerateTree(new int?[] { 2, 2, 2, 5, 2 });

            var solution = new _0965_UnivaluedBinaryTree();
            var result = solution.IsUnivalTree(root);
            Assert.IsFalse(result);
        }
    }
}
