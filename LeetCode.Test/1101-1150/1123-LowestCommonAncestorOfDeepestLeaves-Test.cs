namespace LeetCode.Test
{
    public class _1123_LowestCommonAncestorOfDeepestLeaves_Test
    {
        [Test]
        public void LcaDeepestLeaves_1() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3 });

            var solution = new _1123_LowestCommonAncestorOfDeepestLeaves();
            var result = solution.LcaDeepestLeaves(root);
            AssertHelper.AssertTree(new int?[] { 1, 2, 3 }, result);
        }

        [Test]
        public void LcaDeepestLeaves_2() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4 });

            var solution = new _1123_LowestCommonAncestorOfDeepestLeaves();
            var result = solution.LcaDeepestLeaves(root);
            AssertHelper.AssertTree(new int?[] { 4 }, result);
        }

        [Test]
        public void LcaDeepestLeaves_3() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 2, 3, 4, 5 });

            var solution = new _1123_LowestCommonAncestorOfDeepestLeaves();
            var result = solution.LcaDeepestLeaves(root);
            AssertHelper.AssertTree(new int?[] { 2, 4, 5 }, result);
        }
    }
}
