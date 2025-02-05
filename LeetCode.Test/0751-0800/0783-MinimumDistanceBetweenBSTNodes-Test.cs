namespace LeetCode.Test
{
    public class _0783_MinimumDistanceBetweenBSTNodes_Test
    {
        [Test]
        public void MinDiffInBST_1() {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 6, 1, 3 });

            var solution = new _0783_MinimumDistanceBetweenBSTNodes();
            var result = solution.MinDiffInBST(root);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void MinDiffInBST_2() {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 3, 2 });

            var solution = new _0783_MinimumDistanceBetweenBSTNodes();
            var result = solution.MinDiffInBST(root);
            Assert.AreEqual(1, result);
        }
    }
}
