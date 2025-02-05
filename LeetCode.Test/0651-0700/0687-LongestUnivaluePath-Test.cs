namespace LeetCode.Test
{
    public class _0687_LongestUnivaluePath_Test
    {
        [Test]
        public void LongestUnivaluePath_1() {
            var root = TestHelper.GenerateTree(new int?[] { 5, 4, 5, 1, 1, null, 5 });

            var solution = new _0687_LongestUnivaluePath();
            var result = solution.LongestUnivaluePath(root);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void LongestUnivaluePath_2() {
            var root = TestHelper.GenerateTree(new int?[] { 1, 4, 5, 4, 4, null, 5 });

            var solution = new _0687_LongestUnivaluePath();
            var result = solution.LongestUnivaluePath(root);
            Assert.AreEqual(2, result);
        }
    }
}
