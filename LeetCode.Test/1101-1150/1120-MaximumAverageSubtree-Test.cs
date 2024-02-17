namespace LeetCode.Test
{
    public class _1120_MaximumAverageSubtree_Test
    {

        [Test]
        public void MaximumAverageSubtree_1() {
            var root = TestHelper.GenerateTree(new int?[] { 5, 6, 1 });
            var solution = new _1120_MaximumAverageSubtree();
            var result = solution.MaximumAverageSubtree(root);
            Assert.AreEqual(6.0, result);
        }
    }
}
