namespace LeetCode.Test
{
    public class _1008_ConstructBinarySearchTreeFromPreorderTraversal_Test
    {
        [Test]
        public void BstFromPreorder_1() {
            var solution = new _1008_ConstructBinarySearchTreeFromPreorderTraversal();
            var result = solution.BstFromPreorder(new int[] { 8, 5, 1, 7, 10, 12 });
            AssertHelper.AssertTree(new int?[] { 8, 5, 10, 1, 7, null, 12 }, result);
        }
    }
}
