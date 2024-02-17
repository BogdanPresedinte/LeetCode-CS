namespace LeetCode.Test
{
    public class _0404_SumOfLeftLeaves_Test
    {
        [Test]
        public void SumOfLeftLeaves_1() {
            var root = TestHelper.GenerateTree(new int?[] { 3, 9, 20, null, null, 15, 7 });

            var solution = new _0404_SumOfLeftLeaves();
            var result = solution.SumOfLeftLeaves(root);
            Assert.AreEqual(24, result);
        }
    }
}
