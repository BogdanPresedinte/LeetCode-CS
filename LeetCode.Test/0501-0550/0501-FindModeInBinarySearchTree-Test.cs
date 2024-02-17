namespace LeetCode.Test
{
    public class _0501_FindModeInBinarySearchTree_Test
    {
        [Test]
        public void FindMode_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 2, 2 });

            var solution = new _0501_FindModeInBinarySearchTree();
            var result = solution.FindMode(root);
            AssertHelper.AssertArray(new int[] { 2 }, result);
        }
    }
}
