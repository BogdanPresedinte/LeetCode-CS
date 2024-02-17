namespace LeetCode.Test
{
    public class _1382_BalanceABinarySearchTree_Test
    {
        [Test]
        public void BalanceBST_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 2, null, 3, null, 4, null, null });

            var solution = new _1382_BalanceABinarySearchTree();
            var result = solution.BalanceBST(root);
            AssertHelper.AssertTree(new int?[] { 3, 2, 4, 1 }, result);
        }
    }
}
