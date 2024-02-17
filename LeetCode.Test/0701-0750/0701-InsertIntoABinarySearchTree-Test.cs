namespace LeetCode.Test
{
    public class _0701_InsertIntoABinarySearchTree_Test
    {
        [Test]
        public void InsertIntoBST_1() {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 7, 1, 3 });

            var solution = new _0701_InsertIntoABinarySearchTree();
            var result = solution.InsertIntoBST(root, 5);
            AssertHelper.AssertTree(new int?[] { 4, 2, 7, 1, 3, 5 }, result);
        }

        [Test]
        public void InsertIntoBST_2() {
            var solution = new _0701_InsertIntoABinarySearchTree();
            var result = solution.InsertIntoBST(null, 5);
            AssertHelper.AssertTree(new int?[] { 5 }, result);
        }
    }
}
