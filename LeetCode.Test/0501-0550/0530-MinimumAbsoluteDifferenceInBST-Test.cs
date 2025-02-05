namespace LeetCode.Test
{
    public class _0530_MinimumAbsoluteDifferenceInBST_Test
    {
        [Test]
        public void GetMinimumDifference_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, null, 3, 2 });

            var solution = new _0530_MinimumAbsoluteDifferenceInBST();
            var result = solution.GetMinimumDifference(root);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetMinimumDifference_2() {
            var root = TestHelper.GenerateTree(new int?[] { 4, 2, 6, 1, 3 });

            var solution = new _0530_MinimumAbsoluteDifferenceInBST();
            var result = solution.GetMinimumDifference(root);
            Assert.AreEqual(1, result);
        }
    }
}
