namespace LeetCode.Test
{
    public class _108_ConvertSortedArrayToBinarySearchTree_Test
    {
        [Test]
        public void SortedArrayToBSTTest() {
            var solution = new _108_ConvertSortedArrayToBinarySearchTree();
            var result = solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            AssertHelper.AssertTree(new int?[] { 0, -3, 9, -10, null, 5 }, result);
        }

        [Test]
        public void SortedArrayToBSTTest_Empty() {
            var solution = new _108_ConvertSortedArrayToBinarySearchTree();
            var result = solution.SortedArrayToBST(new int[] { });
            Assert.IsNull(result);
        }
    }
}
