namespace LeetCode.Test
{
    public class _112_PathSum_Test
    {
        [Test]
        public void HasPathSumTest() {
            var solution = new _112_PathSum();
            Assert.IsTrue(solution.HasPathSum(TestHelper.GenerateTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }), 22));
            Assert.IsTrue(solution.HasPathSum(TestHelper.GenerateTree(new int?[] { 2, 3 }), 5));
            Assert.IsTrue(solution.HasPathSum(TestHelper.GenerateTree(new int?[] { 7, -2 }), 5));
        }

        [Test]
        public void HasPathSumTest_False() {
            var solution = new _112_PathSum();
            Assert.IsFalse(solution.HasPathSum(TestHelper.GenerateTree(new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }), 24));
        }

        [Test]
        public void HasPathSumTest_Null() {
            var solution = new _112_PathSum();
            Assert.IsFalse(solution.HasPathSum(null, 0));
        }
    }
}
