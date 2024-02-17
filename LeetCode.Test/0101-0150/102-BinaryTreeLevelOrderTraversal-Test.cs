namespace LeetCode.Test
{
    public class _102_BinaryTreeLevelOrderTraversal_Test
    {
        [Test]
        public void LevelOrderTest() {
            var solution = new _102_BinaryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 }));
            AssertHelper.AssertList(new List<IList<int>>()
            {
                new List<int>() { 3 },
                new List<int>() { 9, 20 },
                new List<int>() { 15, 7 }
            }, result);
        }

        [Test]
        public void LevelOrderTest_Null() {
            var solution = new _102_BinaryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(null);
            AssertHelper.AssertList(new List<IList<int>>(), result);
        }
    }
}
