namespace LeetCode.Test
{
    public class _0654_MaximumBinaryTree_Test
    {
        [Test]
        public void ConstructMaximumBinaryTree() {
            var solution = new _0654_MaximumBinaryTree();
            var root = solution.ConstructMaximumBinaryTree(new int[] { 3, 2, 1, 6, 0, 5 });
            AssertHelper.AssertTree(new int?[] { 6, 3, 5, null, 2, 0, null, null, 1 }, root);
        }
    }
}
